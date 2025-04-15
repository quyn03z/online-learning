using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
	public class LessonProgressService : ILessonProgressService
	{
		private readonly ILessonProgressRepository _lessonProgressRepository;
		public LessonProgressService(ILessonProgressRepository lessonProgressRepository)
		{
			_lessonProgressRepository = lessonProgressRepository;
		}


		public async Task<List<long>> CheckLessonCompletionAsync(long userId)
		{
			return await _lessonProgressRepository.CheckLessonCompletionAsync(userId);
		}

		public async Task MarkLessonAsCompletedAsync(long userId, long lessonId)
		{
			await _lessonProgressRepository.MarkLessonAsCompletedAsync(userId, lessonId);
		}
		public async Task<List<long>> CheckExistItem(long userId)
		{
			return await _lessonProgressRepository.CheckLessonCompletionAsync(userId);
		}
	}
}
