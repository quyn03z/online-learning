using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
    public class CourseEnrollmentRepository : BaseRepository<CourseEnrollment>, ICourseEnrollentRepository
    {
        public CourseEnrollmentRepository(OnlLearnDBContext dBContext) : base(dBContext) { }

		public async Task<bool> CheckUserPurchaseCourseAsync(long? userId, long courseId)
		{
			if (!userId.HasValue) return false;
			var transactionHistory = await _context.CourseEnrollments
									.FirstOrDefaultAsync(t => t.UserId == userId
													&& t.CourseId == courseId
													&& t.Status == Enums.EnrollmentStatus.Enrolled);
			return transactionHistory != null;
		}
	}
}
