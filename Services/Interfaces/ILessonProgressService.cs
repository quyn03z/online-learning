using OnlineLearning.Models.Domains.CourseModels.LessonModels;

namespace OnlineLearning.Services.Interfaces
{
	public interface ILessonProgressService
	{
		Task MarkLessonAsCompletedAsync(long userId, long lessonId);
		Task<List<long>> CheckLessonCompletionAsync(long userId);
	}
}
