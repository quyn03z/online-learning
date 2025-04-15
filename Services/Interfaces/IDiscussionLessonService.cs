using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Models.DTOs;

namespace OnlineLearning.Services.Interfaces
{
	public interface IDiscussionLessonService
	{
		Task<DiscussionLesson> AddDiscussionLessonAsync(DiscussionLesson discussionLesson);
		Task<IEnumerable<DiscussionLesson>> GetAllDiscussionLessonAsync();
		Task DeleteDiscussionLessonAsync(DiscussionLesson discussionLesson);

		Task UpdateDiscussionLessonAsync(DiscussionLesson discussionLesson);

		Task<List<DiscussionLessonDto>> GetAllDiscussionLessonByLessionIdAysnc(long lessonId);
		Task<List<DiscussionLessonDto>> GetCommentsByLessonIdAsync(long lessonId);

		Task<DiscussionLesson> GetCommentByIdAsync(long discussionId);

		Task DeleteCommentAndRepliesAsync(long discussionId);

	}
}
