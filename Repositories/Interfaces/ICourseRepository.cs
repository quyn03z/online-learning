using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.Miscellaneous;
using OnlineLearning.Models.DTOs;

namespace OnlineLearning.Repositories.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        Task<IEnumerable<Course>> GetAllCourseAsync();
        Task<IEnumerable<Admin_ReviewCourseDto>> GetCoursesListNotApproveYetAsync();

        Task<Course> GetInforCourseByIdAsync(long courseId);

        // GET COURSE DETAIL (USER)
        Task<CourseDetailDTO> GetCourseDetailAsync(long courseId);

        Task<IEnumerable<Course>> GetAllCourseByStatusAsync();
        Task<bool> CheckUserPurchaseCourseAsync(long? userId, long courseId);
        Task<IEnumerable<Course>> GetAllCourseByMentorAsync(long? id);
        Task<List<Course>> GetTopEnrolledCoursesAsync(int top = 4);
        Task<List<Course>> GetLatestApprovedCoursesAsync(int top = 2);

	}
}
