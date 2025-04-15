using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;

namespace OnlineLearning.Services.Interfaces
{
    public interface IOptionsService
    {
        Task<Option> CreateOptionsAsync(OptionsDTO optionsDTO);
        Task UpdateOptionsAsync(OptionsDTO optionsDTO);
        Task DeleteOptionsAsync(Option option);
        Task<IEnumerable<OptionsDTO>> GetAllQuizAsync();
    }
}
