using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
	public class CourseRatingRepository : BaseRepository<CourseRating>, ICourseRatingRepository
	{
		public CourseRatingRepository(OnlLearnDBContext context) : base(context)
		{
		}

		public async Task<CourseRating> GetUserRatingForCourseAsync(long courseId, long userId)
		{
			return await _context.CourseRatings
								.Include(r => r.User) // Lấy thông tin User để hiển thị tên
								.FirstOrDefaultAsync(r => r.CourseId == courseId && r.UserId == userId && r.DeletedAt == null);
		}
	}
}
