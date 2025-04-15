namespace OnlineLearning.Models.DTOs
{
	public class DiscussionLessonDto
	{
		public long DiscussionId { get; set; }
		public long? ParentCommentId { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Comment { get; set; }
		public long? UserId { get; set; }
		public long? LessonId { get; set; }

		// Collection to hold replies
		public List<DiscussionLessonDto> Replies { get; set; } = new List<DiscussionLessonDto>();

		// Optional: Add a property for the user's name if you fetch it
		public string UserName { get; set; }

		public string Avatar { get; set; }

	}
}
