using OnlineLearning.Models.Domains.CourseModels.LessonModels;

namespace OnlineLearning.Repositories.Interfaces
{
	public interface IDiscussionLessonRepository : IBaseRepository<DiscussionLesson>
	{
		Task<IEnumerable<DiscussionLesson>> GetAllDiscussionLessonByLessionIdAysnc(long lessonId);

		Task DeleteCommentAndRepliesAsync(long discussionId);


	}
}
