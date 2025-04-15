using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;

namespace OnlineLearning.Services.Interfaces
{
    public interface IQuizService
    {
        Task<Quiz> CreateQuizAsync(QuizDTO quizDTO);
        Task UpdateQuizAsync(QuizDTO quizDTO);
        Task DeleteQuizAsync(Quiz quiz);
        Task DeleteQuizByIdAsync(long quizId);
        Task<IEnumerable<QuizDTO>> GetAllQuizAsync();
        Task<IEnumerable<QuizDTO>> GetQuizzesByModuleIdAsync(long moduleId);
        Task<QuizDTO> GetQuizByIdAsync(long quizId);
    }
}
