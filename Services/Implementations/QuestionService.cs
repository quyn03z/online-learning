using Microsoft.EntityFrameworkCore;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Models.ViewModels;
using OnlineLearning.Repositories;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Services.Implementations
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        
        public async Task<Question> CreateQuestionAsync(QuestionsDTO questionsDTO)
        {
            var question = new Question
            {
                QuizId = questionsDTO.QuizId,
                QuestionId = questionsDTO.QuestionId,
                QuestionName = questionsDTO.QuestionName,
                Type = QuestionType.CheckBox,
                Status = (CommonStatus)QuestionStatus.Active
            };
            return await _questionRepository.AddAsync(question);
        }

        public async Task CreateQuestionWithOptionsAsync(QuestionsDTO questionDTO, List<OptionsDTO> optionsDTO, QuizDTO quizDTO)
        {
            await _questionRepository.CreateQuestionAsync(questionDTO, optionsDTO, quizDTO);
        }

        public async Task DeleteQuestionAsync(long questionId)
        {
            var question = await _questionRepository.GetByIdAsync(questionId);
            if (question != null)
            {
                await _questionRepository.DeleteQuestionAsync(question);
            }
        }

        public async Task<IEnumerable<QuestionsDTO>> GetAllQuestionAsync()
        {
            // Lấy tất cả các câu hỏi từ repository
            var questions = await _questionRepository.GetAllAsync();
            
            // Chuyển đổi thành DTO
            var questionsDTO = questions.Select(q => new QuestionsDTO
            {
                QuestionId = q.QuestionId,
                QuizId = q.QuizId,
                QuestionName = q.QuestionName,
                Type = q.Type
            });
            
            return questionsDTO;
        }

        public async Task<List<QuestionWithOptionsDTO>> GetAllQuestionsWithOptionsAsync()
        {
            // Lấy tất cả các câu hỏi từ repository
            var questions = await _questionRepository.GetAllAsync();
            
            // Danh sách kết quả
            var result = new List<QuestionWithOptionsDTO>();
            
            // Với mỗi câu hỏi, lấy các options tương ứng
            foreach (var question in questions)
            {
                var options = await _questionRepository.GetOptionsByQuestionIdAsync(question.QuestionId);
                
                // Tạo DTO
                var questionWithOptions = new QuestionWithOptionsDTO
                {
                    QuestionId = question.QuestionId,
                    QuizId = question.QuizId,
                    QuestionName = question.QuestionName,
                    Type = question.Type,
                    Options = options.Select(o => new OptionsDTO
                    {
                        OptionId = o.OptionId,
                        QuestionId = o.QuestionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList()
                };
                
                result.Add(questionWithOptions);
            }
            
            return result;
        }

        public async Task<List<QuestionWithOptionsDTO>> GetAllQuestionsWithOptionsByQuizIdAsync(long quizId)
        {
            // Lấy tất cả các câu hỏi từ repository
            var questions = await _questionRepository.GetAllAsync();
            
            // Lọc câu hỏi theo QuizId
            questions = questions.Where(q => q.QuizId == quizId).ToList();
            
            // Danh sách kết quả
            var result = new List<QuestionWithOptionsDTO>();
            
            // Với mỗi câu hỏi, lấy các options tương ứng
            foreach (var question in questions)
            {
                var options = await _questionRepository.GetOptionsByQuestionIdAsync(question.QuestionId);
                
                // Tạo DTO
                var questionWithOptions = new QuestionWithOptionsDTO
                {
                    QuestionId = question.QuestionId,
                    QuizId = question.QuizId,
                    QuestionName = question.QuestionName,
                    Type = question.Type,
                    Options = options.Select(o => new OptionsDTO
                    {
                        OptionId = o.OptionId,
                        QuestionId = o.QuestionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList()
                };
                
                result.Add(questionWithOptions);
            }
            
            return result;
        }

        public async Task UpdateQuestionAsync(QuestionsDTO questionsDTO)
        {
            // Tìm câu hỏi cần cập nhật
            var question = await _questionRepository.GetByIdAsync(questionsDTO.QuestionId);
            if (question == null)
            {
                throw new Exception($"Không tìm thấy câu hỏi có ID: {questionsDTO.QuestionId}");
            }
            
            // Cập nhật thông tin của câu hỏi
            question.QuestionName = questionsDTO.QuestionName;
            question.Type = questionsDTO.Type;
            
            // Lưu thay đổi
            await _questionRepository.UpdateAsync(question);
        }
        
        // Phương thức cập nhật câu hỏi và các options
        public async Task UpdateQuestionWithOptionsAsync(QuestionsDTO questionsDTO, List<OptionsDTO> optionsDTO)
        {
            // Gửi repository để cập nhật câu hỏi và các options
            await _questionRepository.UpdateQuestionWithOptionsAsync(questionsDTO, optionsDTO);
        }
        
        // Phương thức lấy câu hỏi theo ID kèm theo các options
        public async Task<QuestionWithOptionsDTO> GetQuestionWithOptionsById(long questionId)
        {
            // Lấy câu hỏi từ repository
            var questionDTO = await _questionRepository.GetQuestionWithOptionsById(questionId);
            if (questionDTO == null)
            {
                return null;
            }
            
            // Chuyển đổi từ QuestionsDTO sang QuestionWithOptionsDTO
            var questionWithOptionsDTO = new QuestionWithOptionsDTO
            {
                QuestionId = questionDTO.QuestionId,
                QuizId = questionDTO.QuizId,
                QuestionName = questionDTO.QuestionName,
                Type = questionDTO.Type,
                Options = questionDTO.Options
            };
            
            return questionWithOptionsDTO;
        }
    }
}
