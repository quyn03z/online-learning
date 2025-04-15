using Moq;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;
using System.Threading.Tasks;

namespace OnlineLearning.Tests.Services
{
	public class LessonServiceTests
	{
		private readonly Mock<ILessonRepository> _mockLessonRepository;
		private readonly LessonService _lessonService;

		public LessonServiceTests()
		{
			_mockLessonRepository = new Mock<ILessonRepository>();
			_lessonService = new LessonService(_mockLessonRepository.Object, null); // Pass null for IConfiguration if not needed
		}
		/* HẢI - start*/
		[Fact]
		public async Task UpdateLessonAsync_ValidLesson_ReturnsTrue()
		{
			// Arrange
			var lesson = new Lesson { LessonId = 1, LessonName = "Updated Lesson", LessonContent = "Updated Content" };

			_mockLessonRepository.Setup(r => r.UpdateAsync(lesson)).Returns(Task.CompletedTask);

			// Act
			var result = await _lessonService.UpdateLessonAsync(lesson);

			// Assert
			Assert.True(result);
			_mockLessonRepository.Verify(r => r.UpdateAsync(lesson), Times.Once);
		}

		[Fact]
		public async Task UpdateLessonAsync_NullLesson_ReturnsFalse()
		{
			// Act
			var result = await _lessonService.UpdateLessonAsync(null);

			// Assert
			Assert.False(result);
			_mockLessonRepository.Verify(r => r.UpdateAsync(It.IsAny<Lesson>()), Times.Never);
		}

		[Fact]
		public async Task UpdateLessonAsync_UpdateThrowsException_ReturnsFalse()
		{
			// Arrange
			var lesson = new Lesson { LessonId = 1, LessonName = "Lesson", LessonContent = "Content" };

			_mockLessonRepository.Setup(r => r.UpdateAsync(lesson)).ThrowsAsync(new System.Exception("Update failed"));

			// Act
			var result = await _lessonService.UpdateLessonAsync(lesson);

			// Assert
			Assert.False(result);
			_mockLessonRepository.Verify(r => r.UpdateAsync(lesson), Times.Once);
		}
		/* HẢI - end */

	}
}