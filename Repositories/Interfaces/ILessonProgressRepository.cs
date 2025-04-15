using OnlineLearning.Data;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Repositories.Implementations;

namespace OnlineLearning.Repositories.Interfaces
{
	public interface ILessonProgressRepository:IBaseRepository<LessonProgress>
	{
		Task MarkLessonAsCompletedAsync(long userId, long lessonId);
		Task<List<long>> CheckLessonCompletionAsync(long userId);
	}
}
