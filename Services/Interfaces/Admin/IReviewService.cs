using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Services.Interfaces.Admin
{
    public interface IReviewService
    {
        Task<AdminReviewCourse> GetLatestReviewByCourseId(long courseId);
    }
}
