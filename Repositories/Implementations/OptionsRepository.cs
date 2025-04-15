using OnlineLearning.Data;
using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
    public class OptionsRepository : BaseRepository<Option>, IOptionsRepository
    {
        public OptionsRepository(OnlLearnDBContext context) : base(context)
        {
        }
    }
}
