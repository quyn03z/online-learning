using Google.Apis.YouTube.v3;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;
using System.Xml;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;

namespace OnlineLearning.Services.Implementations
{
	public class CourseService : ICourseService
	{
		private readonly ICourseRepository _courseRepository;
		private readonly IConfiguration _configuration;

		public CourseService(ICourseRepository courseRepository, IConfiguration configuration)
		{
			_courseRepository = courseRepository;
			_configuration = configuration;
		}

		public async Task<Course> AddCourseAsync(Course course)
		{
			return await _courseRepository.AddAsync(course);
		}

		public async Task<IEnumerable<Course>> GetAllCourseAsync()
		{
			return await _courseRepository.GetAllCourseAsync();
		}
		public Task<Course?> AdminReviewGetCourseByIdAsync(long courseId)
		{
			throw new NotImplementedException();
		}

		//public async Task<IEnumerable<Course>> GetAllCourseAsync()
		//{
		//    return await _courseRepository.GetAllCourseAsync();
		//}

		public async Task<IEnumerable<Course>> GetAllCourseByStatusAsync()
		{
			return await _courseRepository.GetAllCourseByStatusAsync();
		}

		public async Task<Course?> GetCourseByIdAsync(long courseId)
		{
			return await _courseRepository.GetByIdAsync(courseId);
		}

		public async Task<Course> GetInforCourseByIdAsync(long courseId)
		{
			return await _courseRepository.GetInforCourseByIdAsync(courseId);
		}
		public async Task<IEnumerable<Admin_ReviewCourseDto>> GetCoursesListNotApproveYetAsync()
		{
			return await _courseRepository.GetCoursesListNotApproveYetAsync();
		}

		//public async Task<Course> GetInforCourseByIdAsync(long courseId)
		//{
		//    return await _courseRepository.GetInforCourseByIdAsync(courseId);
		//}

		public async Task UpdateCourseAsync(Course course)
		{
			await _courseRepository.UpdateAsync(course);
		}

		/* Hải - start: course detail */
		// Lấy thông tin chi tiết course
		public async Task<CourseDetailDTO> GetCourseDetailAsync(long courseId)
		{
			var courseDetailDto = await _courseRepository.GetCourseDetailAsync(courseId);
			var youtubeApiKey = _configuration["Youtube:ApiKey"];

			if (courseDetailDto == null)
			{
				return null;
			}

			if (string.IsNullOrEmpty(youtubeApiKey))
			{
				throw new InvalidOperationException("YouTube API Key is not configured.");
			}

			var totalDuration = await CalculateTotalDurationAsync(courseDetailDto.Modules, youtubeApiKey);
			courseDetailDto.Course.StudyTime = FormatTimeSpan(totalDuration);
			return courseDetailDto;
		}

		//Tính total study time 
		public async Task<TimeSpan> CalculateTotalDurationAsync(IEnumerable<Module> modules, string apiKey)
		{
			var youtubeService = new YouTubeService(new BaseClientService.Initializer()
			{
				ApiKey = apiKey,
				ApplicationName = "CourseDetailApp"
			});

			TimeSpan totalDuration = TimeSpan.Zero;

			foreach (var module in modules)
			{
				foreach (var lesson in module.Lessons)
				{
					string videoId = ExtractVideoId(lesson.LessonVideo);
					if (!string.IsNullOrEmpty(videoId))
					{
						lesson.Duration = await GetVideoDurationAsync(youtubeService, videoId);
						totalDuration = totalDuration.Add(TimeSpan.FromSeconds((double)lesson.Duration));
					}
					else
					{
						lesson.Duration = 0;
					}
				}
			}

			return totalDuration;
		}
		// Lấy duration của video
		public async Task<int> GetVideoDurationAsync(YouTubeService youtubeService, string videoId)
		{
			try
			{
				var videoRequest = youtubeService.Videos.List("contentDetails");
				videoRequest.Id = videoId;
				var videoResponse = await videoRequest.ExecuteAsync();

				if (videoResponse.Items.Count > 0)
				{
					var durationIso = videoResponse.Items[0].ContentDetails.Duration;
					var duration = System.Xml.XmlConvert.ToTimeSpan(durationIso);
					return (int)duration.TotalSeconds;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching duration for video {videoId}: {ex.Message}");
			}
			return 0;
		}

		// Hàm trích xuất ID từ URL YouTube
		public string ExtractVideoId(string url)
		{
			if (string.IsNullOrEmpty(url)) return null;

			try
			{
				var uri = new Uri(url);
				var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
				return query["v"] ?? url.Split('/').LastOrDefault()?.Split('?').FirstOrDefault();
			}
			catch
			{
				return null;
			}
		}

		// Chuyển định dạng TimeSpan thành chuỗi
		public string FormatTimeSpan(TimeSpan timeSpan)
		{
			int hours = (int)timeSpan.TotalHours;
			int minutes = timeSpan.Minutes;
			int seconds = timeSpan.Seconds;

			if (hours > 0)
			{
				return $"{hours} hour{(hours > 1 ? "s" : "")} {minutes} minute{(minutes > 1 ? "s" : "")}";
			}
			else if (minutes > 0)
			{
				return $"{minutes} minute{(minutes > 1 ? "s" : "")} {seconds} second{(seconds > 1 ? "s" : "")}";
			}
			else
			{
				return $"{seconds} second{(seconds > 1 ? "s" : "")}";
			}
		}

        public async Task<bool> CheckPurchaseCourseAsync(long? userId, long couseId)
        {
            return await _courseRepository.CheckUserPurchaseCourseAsync(userId, couseId);
        }

        public async Task<IEnumerable<Course>> GetAllCourseByMentorAsync(long? id)
        {
            return await _courseRepository.GetAllCourseByMentorAsync(id);
        }
    }

}
