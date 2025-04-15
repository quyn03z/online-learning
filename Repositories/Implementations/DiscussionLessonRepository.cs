using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
	public class DiscussionLessonRepository : BaseRepository<DiscussionLesson>, IDiscussionLessonRepository
	{
		public DiscussionLessonRepository(OnlLearnDBContext context) : base(context)
		{
		}

		public async Task DeleteCommentAndRepliesAsync(long discussionId)
		{
			  var comment = await _context.DiscussionLessons
				.FirstOrDefaultAsync(dl => dl.DisscussionId == discussionId);
			if (comment == null)
			{
				return;
			}

			var replies = await _context.DiscussionLessons
				.Where(dl => dl.ParentCommentID == discussionId)
				.ToListAsync();

			if (replies.Any())
			{
				_context.DiscussionLessons.RemoveRange(replies);
			}
			_context.DiscussionLessons.Remove(comment);
			await _context.SaveChangesAsync();
		}


		public async Task<IEnumerable<DiscussionLesson>> GetAllDiscussionLessonByLessionIdAysnc(long lessonId)
		{
			return await _context.DiscussionLessons
			.Where(d => d.LessonId == lessonId && d.Comment != null) // Ensure Comment is not null
			.OrderByDescending(d => d.CreatedAt) // Sort by creation date (newest first)
			.ToListAsync();
		}




	}
}
