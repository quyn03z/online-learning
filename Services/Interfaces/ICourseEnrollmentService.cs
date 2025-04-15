using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Services.Interfaces
{
	public interface ICourseEnrollmentService
	{
		Task<bool> AddCourseEnrollmmentAsync(CourseEnrollment courseEnrollment);
		Task<bool> CheckCourseEnrollment(long? userId, long courseId);
	}
}
