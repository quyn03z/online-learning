using OnlineLearning.Models.Domains.CourseModels.CategoryModels;

namespace OnlineLearning.Services.Interfaces
{
    public interface ILanguageService
    {
        Task<IEnumerable<Language>> GetAllLanguageAysnc();
        Task<Language> GetLanguageByIdAsync(long id);
        Task AddLanguageAsync(Language language);
        Task UpdateLanguageAsync(Language language);
        Task DeleteLanguageAsync(Language language);
    }

}
