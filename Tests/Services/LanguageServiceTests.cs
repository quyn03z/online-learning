using Moq;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;

namespace OnlineLearning.Tests.Services
{
    public class LanguageServiceTests
    {
        private readonly Mock<ILanguageRepository> _languageRepositoryMock;
        private readonly LanguageService _languageService;

        public LanguageServiceTests()
        {
            _languageRepositoryMock = new Mock<ILanguageRepository>();
            _languageService = new LanguageService(_languageRepositoryMock.Object);
        }

        [Fact]
        public async Task GetAllLanguageAysnc_ShouldReturnAllLanguages()
        {
            // Arrange
            var languages = new List<Language>
            {
                new Language { LanguageId = 1, LanguageName = "English" },
                new Language { LanguageId = 2, LanguageName = "Vietnamese" }
            };
            _languageRepositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(languages);

            // Act
            var result = await _languageService.GetAllLanguageAysnc();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, l => l.LanguageName == "English");
            Assert.Contains(result, l => l.LanguageName == "Vietnamese");
        }

        [Fact]
        public async Task GetLanguageByIdAsync_ShouldReturnLanguage_WhenExists()
        {
            // Arrange
            var language = new Language { LanguageId = 1, LanguageName = "English" };
            _languageRepositoryMock.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(language);

            // Act
            var result = await _languageService.GetLanguageByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("English", result.LanguageName);
        }

        [Fact]
        public async Task GetLanguageByIdAsync_ShouldReturnNull_WhenNotExists()
        {
            // Arrange
            _languageRepositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<long>())).ReturnsAsync((Language)null);

            // Act
            var result = await _languageService.GetLanguageByIdAsync(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task AddLanguageAsync_ShouldCallRepositoryAddAsync()
        {
            // Arrange
            var language = new Language { LanguageId = 1, LanguageName = "English" };

            // Act
            await _languageService.AddLanguageAsync(language);

            // Assert
            _languageRepositoryMock.Verify(repo => repo.AddAsync(language), Times.Once);
        }

        [Fact]
        public async Task UpdateLanguageAsync_ShouldCallRepositoryUpdateAsync()
        {
            // Arrange
            var language = new Language { LanguageId = 1, LanguageName = "English" };

            // Act
            await _languageService.UpdateLanguageAsync(language);

            // Assert
            _languageRepositoryMock.Verify(repo => repo.UpdateAsync(language), Times.Once);
        }

        [Fact]
        public async Task DeleteLanguageAsync_ShouldCallRepositoryDeleteAsync()
        {
            // Arrange
            var language = new Language { LanguageId = 1, LanguageName = "English" };

            // Act
            await _languageService.DeleteLanguageAsync(language);

            // Assert
            _languageRepositoryMock.Verify(repo => repo.DeleteAsync(language), Times.Once);
        }
    }
}
