using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces.Admin;

namespace OnlineLearning.Services.Implementations.Admin
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public async Task<AdminReviewCourse> GetLatestReviewByCourseId(long courseId)
        {
            return await _reviewRepository.GetLatestReviewByCourseIdAsync(courseId);
        }
    }
}
