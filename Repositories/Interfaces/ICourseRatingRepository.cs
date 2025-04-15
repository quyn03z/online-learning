using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Repositories.Interfaces
{
	public interface ICourseRatingRepository : IBaseRepository<CourseRating>
	{
		Task<CourseRating> GetUserRatingForCourseAsync(long courseId, long userId);
	}
}
