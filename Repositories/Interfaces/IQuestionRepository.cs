using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;
namespace OnlineLearning.Repositories.Interfaces
{
    public interface IQuestionRepository : IBaseRepository<Question>
    {
        Task CreateQuestionAsync(QuestionsDTO questionDTO, List<OptionsDTO> optionsDTO, QuizDTO quizDTO);
        Task<List<Option>> GetOptionsByQuestionIdAsync(long questionId);
        Task DeleteQuestionAsync(Question question);
        
        // Phương thức lấy câu hỏi theo ID kèm theo các options
        Task<QuestionsDTO> GetQuestionWithOptionsById(long questionId);
        
        // Phương thức cập nhật câu hỏi kèm theo các options
        Task UpdateQuestionWithOptionsAsync(QuestionsDTO questionDTO, List<OptionsDTO> optionsDTO);
        
        // Phương thức lấy tất cả câu hỏi kèm theo các options
        Task<List<QuestionsDTO>> GetAllQuestionsWithOptionsAsync();

        
    }
}
