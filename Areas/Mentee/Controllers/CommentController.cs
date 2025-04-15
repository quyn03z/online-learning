using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Areas.Mentee.Controllers
{
	[Area("Mentee")]
	public class CommentController : Controller
	{
		private readonly IDiscussionLessonService _discussionLessonService;

		public CommentController(IDiscussionLessonService discussionLessonService)
		{
			_discussionLessonService = discussionLessonService;
		}

		public async Task<IActionResult> Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(string content, long lessonId, long userId, long courseId, long? parentCommentId = null)
		{
			// Validate input
			if (string.IsNullOrEmpty(content))
			{
				TempData["Error"] = "Bình luận không được để trống.";
				return RedirectToAction("IndexAsync", "Lesson", new { area = "Mentee", courseId, lessonId });
			}

			try
			{
				var newComment = new DiscussionLesson
				{
					Comment = content,
					LessonId = lessonId,
					UserId = userId,
					CreatedAt = DateTime.Now,
					ParentCommentID = parentCommentId
				};

				await _discussionLessonService.AddDiscussionLessonAsync(newComment);
				TempData["Success"] = "Bình luận của bạn đã được thêm!";
			}
			catch (Exception ex)
			{
				TempData["ErrorMessage"] = "Có lỗi xảy ra khi thêm bình luận. Vui lòng thử lại.";
				// Log the exception if needed
			}

			return RedirectToAction("IndexAsync", "Lesson", new { area = "Mentee", courseId, lessonId });
		}

		[HttpPost]
		public async Task<IActionResult> Delete(long discussionId)
		{
			var comment = await _discussionLessonService.GetCommentByIdAsync(discussionId);
			if (comment == null)
			{
				return NotFound();
			}
			await _discussionLessonService.DeleteCommentAndRepliesAsync(discussionId);

			TempData["Success"] = "Xóa Comment thành công!";

			// Lấy courseId từ Session
			long courseId = long.Parse(HttpContext.Session.GetString("CourseId"));
			return RedirectToAction("IndexAsync", "Lesson", new { courseId, lessonId = comment.LessonId });
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int discussionId, string comment, long lessonId, long courseId)
		{
			// Kiểm tra dữ liệu đầu vào
			if (string.IsNullOrEmpty(comment))
			{
				TempData["Error"] = "Bình luận không được để trống.";
			}

			// Tìm bình luận trong cơ sở dữ liệu
			var existingComment = await _discussionLessonService.GetCommentByIdAsync(discussionId);


			// Cập nhật nội dung bình luận
			existingComment.Comment = comment;
			existingComment.UpdatedAt = DateTime.Now;


			// Lưu thay đổi vào cơ sở dữ liệu
			await _discussionLessonService.UpdateDiscussionLessonAsync(existingComment);

			// Trả về phản hồi thành công
			TempData["Success"] = "Bình luận đã được cập nhật.";
			return RedirectToAction("IndexAsync", "Lesson", new { area = "Mentee", courseId, lessonId });

		}


		[HttpPost]
		public async Task<IActionResult> Replies(int lessonId, int userId, int parentCommentId, string content,long courseId)
		{
			// Kiểm tra dữ liệu đầu vào
			if (string.IsNullOrEmpty(content))
			{
				TempData["Error"] = "Bình luận không được để trống.";
				return RedirectToAction("IndexAsync", "Lesson", new { area = "Mentee", courseId, lessonId });
			}

			// Tạo đối tượng phản hồi mới
			var reply = new DiscussionLesson
			{
				LessonId = lessonId,
				UserId = userId,
				ParentCommentID = parentCommentId, // Liên kết với bình luận cha
				Comment = content,
				CreatedAt = DateTime.Now,
			};

			// Lưu phản hồi vào cơ sở dữ liệu
			await _discussionLessonService.AddDiscussionLessonAsync(reply);

			TempData["Success"] = "Bình luận của bạn đã được thêm!";
			return RedirectToAction("IndexAsync", "Lesson", new { area = "Mentee", courseId, lessonId });
		}


	}
}
