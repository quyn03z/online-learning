using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
	public class CourseRatingService : ICourseRatingService
	{
		private readonly ICourseRatingRepository _courseRatingRepository;

		public CourseRatingService(ICourseRatingRepository courseRatingRepository)
		{
			_courseRatingRepository = courseRatingRepository;
		}

		public async Task AddCourseRatingAsync(CourseRating courseRating)
		{
			 await _courseRatingRepository.AddAsync(courseRating);
		}

		public async Task<CourseRating> GetUserRatingForCourseAsync(long courseId, long userId)
		{
			return await _courseRatingRepository.GetUserRatingForCourseAsync(courseId, userId);
		}
	}
}
