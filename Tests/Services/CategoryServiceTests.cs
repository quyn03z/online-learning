using Moq;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;

namespace OnlineLearning.Tests.Services
{
    public class CategoryServiceTests
    {
        private readonly Mock<ICategoryRepository> _categoryRepositoryMock;
        private readonly CategoryService _categoryService;

        public CategoryServiceTests()
        {
            _categoryRepositoryMock = new Mock<ICategoryRepository>();
            _categoryService = new CategoryService(_categoryRepositoryMock.Object);
        }

        [Fact]
        public async Task GetAllCategoryAysnc_ShouldReturnAllCategories()
        {
            // Arrange
            var categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Programming" },
                new Category { CategoryId = 2, CategoryName = "Design" }
            };
            _categoryRepositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(categories);

            // Act
            var result = await _categoryService.GetAllCategoryAysnc();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, c => c.CategoryName == "Programming");
            Assert.Contains(result, c => c.CategoryName == "Design");
        }

        [Fact]
        public async Task GetCategoryByIdAsync_ShouldReturnCategory_WhenExists()
        {
            // Arrange
            var category = new Category { CategoryId = 1, CategoryName = "Programming" };
            _categoryRepositoryMock.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(category);

            // Act
            var result = await _categoryService.GetCategoryByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Programming", result.CategoryName);
        }

        [Fact]
        public async Task GetCategoryByIdAsync_ShouldReturnNull_WhenNotExists()
        {
            // Arrange
            _categoryRepositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<long>())).ReturnsAsync((Category)null);

            // Act
            var result = await _categoryService.GetCategoryByIdAsync(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task AddCategoryAsync_ShouldCallRepositoryAddAsync()
        {
            // Arrange
            var category = new Category { CategoryId = 1, CategoryName = "Programming" };

            // Act
            await _categoryService.AddCategoryAsync(category);

            // Assert
            _categoryRepositoryMock.Verify(repo => repo.AddAsync(category), Times.Once);
        }

        [Fact]
        public async Task UpdateCategoryAsync_ShouldCallRepositoryUpdateAsync()
        {
            // Arrange
            var category = new Category { CategoryId = 1, CategoryName = "Programming" };

            // Act
            await _categoryService.UpdateCategoryAsync(category);

            // Assert
            _categoryRepositoryMock.Verify(repo => repo.UpdateAsync(category), Times.Once);
        }

        [Fact]
        public async Task DeleteCategoryAsync_ShouldCallRepositoryDeleteAsync()
        {
            // Arrange
            var category = new Category { CategoryId = 1, CategoryName = "Programming" };

            // Act
            await _categoryService.DeleteCategoryAsync(category);

            // Assert
            _categoryRepositoryMock.Verify(repo => repo.DeleteAsync(category), Times.Once);
        }
    }
}