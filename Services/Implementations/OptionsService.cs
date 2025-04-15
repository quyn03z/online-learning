using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
    public class OptionsService: IOptionsService
    {
        private readonly IOptionsRepository _optionsRepository;

        public OptionsService(IOptionsRepository optionsRepository)
        {
            _optionsRepository = optionsRepository;
        }

        public Task<Option> CreateOptionsAsync(OptionsDTO optionsDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOptionsAsync(Option option)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OptionsDTO>> GetAllQuizAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateOptionsAsync(OptionsDTO optionsDTO)
        {
            throw new NotImplementedException();
        }
    }
}
