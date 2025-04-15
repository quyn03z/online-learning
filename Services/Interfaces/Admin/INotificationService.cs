using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;

namespace OnlineLearning.Services.Interfaces.Admin
{
    public interface INotificationService
    {
        Task AddNotification(Notification notification);
        Task IsReaded(long courseId,bool isRead);
        Task<List<Notification>> GetAllNotifications();
        Task<List<Notification>> GetAllNotificationsIsNotClear();

        Task<List<Notification>> GetAllNotificationsIsNotRead();

        Task MarkAllRead();
        Task ClearAll();

    }
}
