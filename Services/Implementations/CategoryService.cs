using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

      
        public async Task<IEnumerable<Category>> GetAllCategoryAysnc()
        {
            return await _categoryRepository.GetAllAsync();
        }
        
        public async Task<Category> GetCategoryByIdAsync(long id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _categoryRepository.AddAsync(category);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteCategoryAsync(Category category)
        {
            category.Status = CategoryStatus.Deleted;
            await _categoryRepository.UpdateAsync(category);
        }
    }
}
