using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;

namespace OnlineLearning.Repositories.Interfaces
{
    public interface INotificationRepository : IBaseRepository<Notification>
    {
        Task<List<Notification>> GetNotificationIsNotRead();
        Task<List<Notification>> GetAllNotificationAysnc();
        Task<List<Notification>> GetNotificationAysncIsNotClear();
        Task MarkAllRead(List<Notification> notifications);
        Task ClearAll();
        Task<Notification> GetNotificationByCourseId(long courseId, bool isRead);
    }
}
