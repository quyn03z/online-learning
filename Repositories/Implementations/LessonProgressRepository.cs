using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Models.Domains.UserModels;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
	public class LessonProgressRepository: BaseRepository<LessonProgress>, ILessonProgressRepository
	{
		public LessonProgressRepository(OnlLearnDBContext context) : base(context) { }

		public async Task<List<long>> CheckLessonCompletionAsync(long userId)
		{
			return await _context.LessonProgresses
				.Where(lp => lp.UserId == userId)
				.Select(lp => lp.LessonId)
				.ToListAsync();
		}

		public async Task MarkLessonAsCompletedAsync(long userId, long lessonId)
		{
			var progress = await _context.LessonProgresses
			.FirstOrDefaultAsync(p => p.UserId == userId && p.LessonId == lessonId);

			if (progress == null)
			{
				// Nếu chưa có bản ghi, tạo mới
				progress = new LessonProgress
				{
					UserId = userId,
					LessonId = lessonId,
					CompletedAt = DateTime.Now
				};
				_context.LessonProgresses.Add(progress);
			}

			await _context.SaveChangesAsync();
		}
	}
}
