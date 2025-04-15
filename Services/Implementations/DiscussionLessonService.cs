using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
	public class DiscussionLessonService : IDiscussionLessonService
	{
		private readonly IDiscussionLessonRepository _discussionLessonRepository;
		private readonly IUserService _userService;
		private IDiscussionLessonRepository @object;

		public DiscussionLessonService(IDiscussionLessonRepository @object)
		{
			this.@object = @object;
		}

		public DiscussionLessonService(IDiscussionLessonRepository discussionLessonRepository, IUserService userService)
		{
			_discussionLessonRepository = discussionLessonRepository;
			_userService = userService;
		}

		public async Task<DiscussionLesson> AddDiscussionLessonAsync(DiscussionLesson discussionLesson)
		{
			return await _discussionLessonRepository.AddAsync(discussionLesson);
		}

		public async Task DeleteCommentAndRepliesAsync(long discussionId)
		{
			 await _discussionLessonRepository.DeleteCommentAndRepliesAsync(discussionId);
		}

		public async Task DeleteDiscussionLessonAsync(DiscussionLesson discussionLesson)
		{
			 await _discussionLessonRepository.DeleteAsync(discussionLesson);
		}

		public async Task<IEnumerable<DiscussionLesson>> GetAllDiscussionLessonAsync()
		{
			return await _discussionLessonRepository.GetAllAsync();
		}

		public async Task<List<DiscussionLessonDto>> GetAllDiscussionLessonByLessionIdAysnc(long lessionId)
		{
			// Fetch all comments for the given LessonId using the repository
			var allComments = await _discussionLessonRepository.GetAllDiscussionLessonByLessionIdAysnc(lessionId);



			// Map DiscussionLesson entities to DiscussionLessonDto
			var allCommentDtos = new List<DiscussionLessonDto>();
			foreach (var c in allComments)
			{
				var user = await _userService.GetUserByIdAsync(c.UserId);

				var dto = new DiscussionLessonDto
				{
					DiscussionId = c.DisscussionId,
					ParentCommentId = c.ParentCommentID,
					CreatedAt = c.CreatedAt,
					UpdatedAt = c.UpdatedAt,
					Comment = c.Comment,
					UserId = c.UserId,
					LessonId = c.LessonId,
					UserName = await _userService.GetUserNameByIdAsync(c.UserId), // Fetch the user name
					Avatar = user != null ? user.AvatarUrl : "/images/default-avatar.jpg"

				};
				allCommentDtos.Add(dto);
			}

			// Separate top-level comments (ParentCommentId is NULL) and replies
			var topLevelComments = allCommentDtos
				.Where(c => c.ParentCommentId == null)
				.ToList();

			// Assign replies to their parent comments
			foreach (var comment in topLevelComments)
			{
				comment.Replies = allCommentDtos
					.Where(r => r.ParentCommentId == comment.DiscussionId)
					.OrderByDescending(r => r.CreatedAt) // Sort replies by creation date (newest first)
					.ToList();
			}

			return topLevelComments;
		}

		public async Task<DiscussionLesson> GetCommentByIdAsync(long discussionId)
		{
			return await _discussionLessonRepository.GetByIdAsync(discussionId);
		}

		public async Task<List<DiscussionLessonDto>> GetCommentsByLessonIdAsync(long lessonId)
		{
			return await GetAllDiscussionLessonByLessionIdAysnc(lessonId);
		}

		public async Task UpdateDiscussionLessonAsync(DiscussionLesson discussionLesson)
		{
			 await _discussionLessonRepository.UpdateAsync(discussionLesson);
		}

	
	}
}
