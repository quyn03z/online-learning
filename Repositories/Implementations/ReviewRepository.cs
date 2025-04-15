using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
    public class ReviewRepository : BaseRepository<AdminReviewCourse>, IReviewRepository
    {
        public ReviewRepository(OnlLearnDBContext context) : base(context) { }

        public async Task<AdminReviewCourse> GetLatestReviewByCourseIdAsync(long courseId)
        {
            return await _context.AdminReviewCourses
                .Where(r => r.CourseId == courseId)
                .OrderByDescending(r => r.ReviewedAt) // Lấy bản ghi mới nhất dựa trên ReviewedAt
                .FirstOrDefaultAsync();
        }
    }
}
