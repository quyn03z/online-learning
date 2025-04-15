using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(OnlLearnDBContext context) : base(context) { }

        public async Task ClearAll()
        {
            var notifications = await _context.Notifications
                .Where(n => n.IsCleared == false)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
            foreach (var notification in notifications)
            {
                notification.IsCleared = true;
            }
            await _context.SaveChangesAsync();

        }

        public async Task<List<Notification>> GetAllNotificationAysnc()
        {
            return await _context.Notifications.ToListAsync();

        }

        public async Task<List<Notification>> GetNotificationAysncIsNotClear()
        {
            return await _context.Notifications
                .Where(n => n.IsCleared == false)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();

        }

        public async Task<Notification> GetNotificationByCourseId(long courseId, bool isRead)
        {

            return await _context.Notifications
      .FirstOrDefaultAsync(x => x.CourseId == courseId && x.IsRead == isRead);

        }

        public async Task<List<Notification>> GetNotificationIsNotRead()
        {
            // Lấy danh sách thông báo chưa đọc
            var notifications = await _context.Notifications
                .Where(n => n.IsRead == false)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
            return notifications;
        }

        public async Task MarkAllRead(List<Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                notification.IsRead = true;
            }
            await _context.SaveChangesAsync();
        }
    }
}
