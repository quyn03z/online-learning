using Microsoft.CodeAnalysis.Host;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Repositories.Implementations;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Services.Implementations
{
    public class LanguageService : OnlineLearning.Services.Interfaces.ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task<IEnumerable<Language>> GetAllLanguageAysnc()
        {
            return await _languageRepository.GetAllAsync();
        }
      
        public async Task<Language> GetLanguageByIdAsync(long id)
        {
            return await _languageRepository.GetByIdAsync(id);
        }

        public async Task AddLanguageAsync(Language language)
        {
            await _languageRepository.AddAsync(language);
        }

        public async Task UpdateLanguageAsync(Language language)
        {
            await _languageRepository.UpdateAsync(language);
        }

        public async Task DeleteLanguageAsync(Language language)
        {
            language.Status = Enums.CategoryStatus.Deleted;
            await _languageRepository.UpdateAsync(language);
        }
    }

}
