using Microsoft.EntityFrameworkCore;
using OnlineLearning.Models.Domains.UserModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearning.Models.Domains.CourseModels.LessonModels
{
	[PrimaryKey(nameof(UserId), nameof(LessonId))]
	public class LessonProgress
	{
		public long UserId { get; set; }
		public long LessonId { get; set; }
		[Required]
		public DateTime CompletedAt { get; set; } = DateTime.Now;

		public virtual User? User { get; set; }
		public virtual Lesson? Lesson { get; set; }

	}
}
