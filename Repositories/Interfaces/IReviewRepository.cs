using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Repositories.Interfaces
{
    public interface IReviewRepository : IBaseRepository<AdminReviewCourse>
    {
        Task<AdminReviewCourse> GetLatestReviewByCourseIdAsync(long courseId);
    }
}
