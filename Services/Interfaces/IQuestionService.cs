using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Models.ViewModels;

namespace OnlineLearning.Services.Interfaces
{
    public interface IQuestionService
    {
        Task CreateQuestionWithOptionsAsync(QuestionsDTO questionDTO, List<OptionsDTO> optionsDTO, QuizDTO quizDTO);
        //Task<Question> CreateQuestionAsync(QuestionsDTO questionsDTO);
        //Task UpdateQuestionAsync(QuestionsDTO questionsDTO);
        Task UpdateQuestionWithOptionsAsync(QuestionsDTO questionsDTO, List<OptionsDTO> optionsDTO);
        Task DeleteQuestionAsync(long questionId);
        Task<IEnumerable<QuestionsDTO>> GetAllQuestionAsync();
        Task<List<QuestionWithOptionsDTO>> GetAllQuestionsWithOptionsAsync();
        Task<QuestionWithOptionsDTO> GetQuestionWithOptionsById(long questionId);
        Task<List<QuestionWithOptionsDTO>> GetAllQuestionsWithOptionsByQuizIdAsync(long quizId);
    }
}
