using Microsoft.AspNetCore.Http;
﻿using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using OnlineLearning.Models.Order;
using OnlineLearning.Services.Implementations;
using OnlineLearning.Services.Interfaces;
using static System.Net.WebRequestMethods;
using System.Security.Claims;
using System.Text;
using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Areas.Mentee.Controllers
{
	[Area("Mentee")]
	public class LessonController : Controller
	{
		private readonly ICourseService _courseService;

		private readonly ICourseEnrollmentService _courseEnrollmentService;
		private readonly ILessonProgressService _lessonProgressService;
		private readonly IDiscussionLessonService _discussionLessonService;
		private readonly ICourseRatingService _courseRatingService;

		public LessonController(ICourseService courseService, ICourseEnrollmentService courseEnrollmentService, ILessonProgressService lessonProgressService, IDiscussionLessonService discussionLessonService, ICourseRatingService courseRatingService)
		{
			_courseService = courseService;
			_courseEnrollmentService = courseEnrollmentService;
			_lessonProgressService = lessonProgressService;
			_discussionLessonService = discussionLessonService;
			_courseRatingService = courseRatingService;
		}

		[HttpGet("Mentee/Lesson/{courseId}/{lessonId?}")]

		public async Task<ActionResult> IndexAsync(long courseId,long? lessonId)
		{
			// check đăng nhập
			if (!HttpContext.Session.TryGetValue("UserId", out var userIdBytes) ||
				!long.TryParse(System.Text.Encoding.UTF8.GetString(userIdBytes), out var userId))
			{
				return RedirectToAction("Index", "Login", new { area = "" });
			}

			long sessionCourseId;
			if (!HttpContext.Session.TryGetValue("CourseId", out var courseIdBytes) ||
				!long.TryParse(System.Text.Encoding.UTF8.GetString(courseIdBytes), out sessionCourseId))
			{
				// Nếu không có CourseId trong Session, sử dụng courseId từ URL và lưu vào Session
				sessionCourseId = courseId;
				HttpContext.Session.SetString("CourseId", courseId.ToString());
			}

			courseId = sessionCourseId;

			// Kiểm tra quyền truy cập khóa học
			if (!await _courseEnrollmentService.CheckCourseEnrollment(userId, courseId))
			{
				//GET COURSE INFORMATION
				var courseInfor = await _courseService.GetCourseByIdAsync(courseId);
				string? fullName = HttpContext.Session.GetString("UserId");

				// CHECKOUT
				if (courseInfor.Price > 0)
				{
					return RedirectToAction("CreatePaymentMomo", "Payment", new
					{
						Area = "",
						amount = courseInfor.Price,
						orderInfor = $"Thanh toán khóa học {courseInfor.CourseName}",
						paymentUserId = userId,
						paymentCourseId = courseId,
						paymentFullName = fullName
					});
				}
				else
				{
					// Thêm vào bảng enrollment
					await _courseEnrollmentService.AddCourseEnrollmmentAsync(new Models.Domains.UserCourseRelationship.CourseEnrollment
					{
						CourseId = courseId,
						CreatedAt = DateTime.UtcNow,
						Progress = 0,
						Status = Enums.EnrollmentStatus.Enrolled,
						UserId = userId,
					});
					return RedirectToAction("Index", "Lesson", new
					{
						courseId = courseId,
					});
				}

			}

			var course = await _courseService.GetCourseDetailAsync(courseId);
			if(course == null)
			{
				ViewBag.IsCourseExisted = false;
				return View();
			}
			// Không có lessonId => default: Id first lesson
			if (!lessonId.HasValue)
			{
					lessonId = course.Modules
			   .OrderBy(m => m.ModuleNumber) // Sắp xếp Module theo số thứ tự
			   .SelectMany(m => m.Lessons)   // Lấy tất cả bài học trong Modules
			   .OrderBy(l => l.LessonNumber) // Sắp xếp bài học theo số thứ tự
			   .FirstOrDefault()?.LessonId;
			}

			var comments = await _discussionLessonService.GetCommentsByLessonIdAsync(lessonId.Value);

			ViewBag.CourseId = courseId;
			ViewBag.UserId = HttpContext.Session.GetString("UserId");
			ViewBag.LessonId = lessonId;
			ViewBag.ModuleId = course.Modules
									.FirstOrDefault(m => m.Lessons.Any(l => l.LessonId == lessonId))?
									.ModuleId;
            ViewBag.Comments = comments;


			ViewBag.CompletedLessonIds = await _lessonProgressService.CheckLessonCompletionAsync(userId);

			var userRating = await _courseRatingService.GetUserRatingForCourseAsync(courseId, userId);
			ViewBag.UserRating = userRating;

			return View(course);
		}

		[HttpPost]
		public async Task<IActionResult> CompleteLesson([FromBody] CompleteLessonRequest request)
		{
			if (!HttpContext.Session.TryGetValue("UserId", out var userIdBytes) ||
				!long.TryParse(Encoding.UTF8.GetString(userIdBytes), out var userId))
			{
				return Unauthorized(new { success = false, message = "Please login to complete lesson" });
			}

			try
			{
				await _lessonProgressService.MarkLessonAsCompletedAsync(userId, request.LessonId);
				return Json(new { success = true, message = "Lesson marked as completed" });
			}
			catch (Exception ex)
			{
				return BadRequest(new { success = false, message = $"Error: {ex.Message}" });
			}
		}



		[HttpPost("Mentee/Lesson/SubmitRating/{courseId}")]
		public async Task<IActionResult> SubmitRating(long courseId, byte rating, string feedback)
		{
			if (!HttpContext.Session.TryGetValue("UserId", out var userIdBytes) ||
				!long.TryParse(System.Text.Encoding.UTF8.GetString(userIdBytes), out var userId))
			{
				return RedirectToAction("Index", "Login", new { area = "" });
			}

			try
			{
				var newRating = new CourseRating
				{
					CourseId = courseId,
					UserId = userId,
					Rating = rating,
					Feedback = feedback,
					CreatedAt = DateTime.UtcNow
				};

				await _courseRatingService.AddCourseRatingAsync(newRating);
				return RedirectToAction("IndexAsync", new { courseId });
			}
			catch (ArgumentException ex)
			{
				TempData["Error"] = ex.Message;
				return RedirectToAction("IndexAsync", new { courseId });
			}
		}


		public class CompleteLessonRequest
		{
			public long LessonId { get; set; }
		}
	}
}
