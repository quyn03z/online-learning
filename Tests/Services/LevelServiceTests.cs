using Moq;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;

namespace OnlineLearning.Tests.Services
{
    public class LevelServiceTests
    {
        private readonly Mock<ILevelRepository> _levelRepositoryMock;
        private readonly LevelService _levelService;

        public LevelServiceTests()
        {
            _levelRepositoryMock = new Mock<ILevelRepository>();
            _levelService = new LevelService(_levelRepositoryMock.Object);
        }

        [Fact]
        public async Task GetAllLevelAysnc_ShouldReturnAllLevels()
        {
            // Arrange
            var levels = new List<Level>
            {
                new Level { LevelId = 1, LevelName = "Beginner" },
                new Level { LevelId = 2, LevelName = "Intermediate" }
            };
            _levelRepositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(levels);

            // Act
            var result = await _levelService.GetAllLevelAysnc();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, l => l.LevelName == "Beginner");
            Assert.Contains(result, l => l.LevelName == "Intermediate");
        }

        [Fact]
        public async Task GetLevelByIdAsync_ShouldReturnLevel_WhenExists()
        {
            // Arrange
            var level = new Level { LevelId = 1, LevelName = "Beginner" };
            _levelRepositoryMock.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(level);

            // Act
            var result = await _levelService.GetLevelByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Beginner", result.LevelName);
        }

        [Fact]
        public async Task GetLevelByIdAsync_ShouldReturnNull_WhenNotExists()
        {
            // Arrange
            _levelRepositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<long>())).ReturnsAsync((Level)null);

            // Act
            var result = await _levelService.GetLevelByIdAsync(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task AddLevelAsync_ShouldCallRepositoryAddAsync()
        {
            // Arrange
            var level = new Level { LevelId = 1, LevelName = "Beginner" };

            // Act
            await _levelService.AddLevelAsync(level);

            // Assert
            _levelRepositoryMock.Verify(repo => repo.AddAsync(level), Times.Once);
        }

        [Fact]
        public async Task UpdateLevelAsync_ShouldCallRepositoryUpdateAsync()
        {
            // Arrange
            var level = new Level { LevelId = 1, LevelName = "Beginner" };

            // Act
            await _levelService.UpdateLevelAsync(level);

            // Assert
            _levelRepositoryMock.Verify(repo => repo.UpdateAsync(level), Times.Once);
        }

        [Fact]
        public async Task DeleteLevelAsync_ShouldCallRepositoryDeleteAsync()
        {
            // Arrange
            var level = new Level { LevelId = 1, LevelName = "Beginner" };

            // Act
            await _levelService.DeleteLevelAsync(level);

            // Assert
            _levelRepositoryMock.Verify(repo => repo.DeleteAsync(level), Times.Once);
        }
    }
}
