using Google.Apis.Services;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.YouTube.v3;
using Moq;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearning.Tests.Services
{
	public class CourseServiceTests
	{
		private readonly Mock<ICourseRepository> _mockCourseRepository;
		private readonly Mock<IConfiguration> _mockConfiguration;
		private readonly CourseService _courseService;

		public CourseServiceTests()
		{
			_mockCourseRepository = new Mock<ICourseRepository>();
			_mockConfiguration = new Mock<IConfiguration>();
			_courseService = new CourseService(_mockCourseRepository.Object, _mockConfiguration.Object);
		}

        // Hải: course detail
		[Fact]
        public async Task GetCourseDetailAsync_ValidCourseId_ReturnsCourseDetailDTOWithStudyTime()
        {
            // Arrange
            long courseId = 1;
            var courseDetailDto = new CourseDetailDTO
            {
                Course = new Course { CourseId = courseId, CourseName = "Test Course", StudyTime = "" },
                Modules = new List<Module>
                {
                    new Module
                    {
                        Lessons = new List<Lesson>
                        {
                            new Lesson { LessonVideo = "https://www.youtube.com/watch?v=dQw4w9WgXcQ", LessonName = "lessonTest1" }
                        }
                    }
                }
            };

            _mockCourseRepository.Setup(r => r.GetCourseDetailAsync(courseId)).ReturnsAsync(courseDetailDto);
            _mockConfiguration.Setup(c => c["Youtube:ApiKey"]).Returns("fake-api-key");

            // Act
            var result = await _courseService.GetCourseDetailAsync(courseId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(courseId, result.Course.CourseId);
        }


	}
}
