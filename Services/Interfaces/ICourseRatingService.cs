using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Services.Interfaces
{
	public interface ICourseRatingService
	{
		Task AddCourseRatingAsync(CourseRating courseRating);
		Task<CourseRating> GetUserRatingForCourseAsync(long courseId, long userId);

	}
}
