using OnlineLearning.Models.Domains.AIModels;
using OnlineLearning.Models.Domains.CourseModels;

namespace OnlineLearning.Models.ViewModels
{
	public class HomeViewModel
	{
		public long? UserId { get; set; }
		public IEnumerable<ChatbotMessage> ChatbotMessage { get; set; } = new List<ChatbotMessage>();
		public List<Course> LatestCoures { get; set; } = new List<Course>();
		public List<Course> PopularCourse { get; set; } = new List<Course>();
	}
}
