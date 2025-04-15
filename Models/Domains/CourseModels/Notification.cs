using OnlineLearning.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearning.Models.Domains.CourseModels
{
    public class Notification
    {
        public long NotificationId { get; set; }
        public long CourseId { get; set; }
        [Required]
        public string CourseName { get; set; } = null!;
        [Required]
        public string CourseUrl { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; } = false;
        public bool IsCleared { get; set; } = false;

        [Required]
        [Column(TypeName = "VARCHAR(20)")] // Lưu dưới dạng chuỗi trong DB
        public NotificationType NotificationType { get; set; } = NotificationType.Add;
        public virtual Course Course { get; set; } = null!;
    }
}
