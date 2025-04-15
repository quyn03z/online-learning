using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.CourseModels.QuizModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
    public class QuestionRepository : BaseRepository<Question> , IQuestionRepository
    {
        private readonly OnlLearnDBContext _context;
        public QuestionRepository(OnlLearnDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task CreateQuestionAsync(QuestionsDTO questionDTO, List<OptionsDTO> optionsDTO, QuizDTO quizDTO)
        {
            // Kiểm tra sự tồn tại của QuizId trước khi thêm Question
            var quizExists = await _context.Quizzes.AnyAsync(q => q.QuizId == quizDTO.QuizId);
            if (!quizExists)
            {
                throw new Exception($"Quiz với ID {questionDTO.QuizId} không tồn tại. Không thể thêm câu hỏi cho Quiz không tồn tại.");
            }
            
            // 1. Chuyển đổi QuestionsDTO thành entity Question
            var question = new Question
            {
                QuizId = quizDTO.QuizId,
                QuestionName = questionDTO.QuestionName,
                Type = questionDTO.Type,
                //CreatedAt = questionDTO.CreatedAt,
                //UpdatedAt = questionDTO.UpdatedAt,
                //Status = questionDTO.Status
            };

            // 2. Thêm Question vào DbContext và lưu để lấy QuestionId
            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();

            // 3. Chuyển đổi List<OptionsDTO> thành List<Option> và gán QuestionId
            var options = optionsDTO.Select(o => new Option
            {
                QuestionId = question.QuestionId, // Gán QuestionId từ Question vừa lưu
                OptionText = o.OptionText,
                IsCorrect = o.IsCorrect,
                //CreatedAt = o.CreatedAt,
                //UpdatedAt = o.UpdatedAt,
                //Status = o.Status
            }).ToList();

            // 4. Thêm các Option vào DbContext và lưu
            await _context.Options.AddRangeAsync(options);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Option>> GetOptionsByQuestionIdAsync(long questionId)
        {
            return await _context.Options
                .Where(o => o.QuestionId == questionId)
                .ToListAsync();
        }

        public async Task DeleteQuestionAsync(Question question)
        {
            // Xóa tất cả các options liên quan đến câu hỏi này trước
            var options = await _context.Options
                .Where(o => o.QuestionId == question.QuestionId)
                .ToListAsync();
            
            if (options.Any())
            {
                _context.Options.RemoveRange(options);
                await _context.SaveChangesAsync();
            }
            
            // Sau đó xóa câu hỏi
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
        }
        
        // Phương thức lấy câu hỏi theo ID kèm theo các options
        public async Task<QuestionsDTO> GetQuestionWithOptionsById(long questionId)
        {
            // Lấy câu hỏi từ database
            var question = await _context.Questions
                .Where(q => q.QuestionId == questionId)
                .FirstOrDefaultAsync();
                
            if (question == null)
            {
                return null;
            }
            
            // Lấy danh sách options của câu hỏi
            var options = await _context.Options
                .Where(o => o.QuestionId == questionId)
                .ToListAsync();
                
            // Tạo QuestionsDTO từ câu hỏi và options
            var questionDTO = new QuestionsDTO
            {
                QuestionId = question.QuestionId,
                QuizId = question.QuizId,
                QuestionName = question.QuestionName,
                Type = question.Type,
                Options = options.Select(o => new OptionsDTO
                {
                    OptionId = o.OptionId,
                    OptionText = o.OptionText,
                    IsCorrect = o.IsCorrect,
                    QuestionId = o.QuestionId
                }).ToList()
            };
            
            return questionDTO;
        }
        
        // Phương thức cập nhật câu hỏi và các options
        public async Task UpdateQuestionWithOptionsAsync(QuestionsDTO questionDTO, List<OptionsDTO> optionsDTO)
        {
            // Tìm câu hỏi cần cập nhật
            var question = await _context.Questions.FindAsync(questionDTO.QuestionId);
            if (question == null)
            {
                throw new Exception($"Không tìm thấy câu hỏi có ID: {questionDTO.QuestionId}");
            }
            
            // Kiểm tra sự tồn tại của QuizId trước khi cập nhật Question
            var quizExists = await _context.Quizzes.AnyAsync(q => q.QuizId == questionDTO.QuizId);
            if (!quizExists)
            {
                throw new Exception($"Quiz với ID {questionDTO.QuizId} không tồn tại. Không thể cập nhật câu hỏi cho Quiz không tồn tại.");
            }
            
            // Cập nhật thông tin của câu hỏi
            question.QuestionName = questionDTO.QuestionName;
            question.Type = questionDTO.Type;
            //question.UpdatedAt = DateTime.Now;
            
            // Lấy danh sách options hiện tại của câu hỏi
            var existingOptions = await _context.Options
                .Where(o => o.QuestionId == questionDTO.QuestionId)
                .ToListAsync();
                
            // Tìm các options cần thêm mới (không có OptionId)
            var newOptions = optionsDTO.Where(o => o.OptionId == 0).ToList();
            
            // Tìm các options cần cập nhật (có OptionId và tồn tại trong database)
            var updatingOptions = optionsDTO.Where(o => o.OptionId != 0).ToList();
            var updatingOptionIds = updatingOptions.Select(o => o.OptionId).ToList();
            
            // Tìm các options cần xóa (có trong database nhưng không có trong danh sách cập nhật)
            var deletingOptions = existingOptions.Where(eo => !updatingOptionIds.Contains(eo.OptionId)).ToList();
            
            // Xóa các options không còn cần thiết
            if (deletingOptions.Any())
            {
                _context.Options.RemoveRange(deletingOptions);
            }
            
            // Cập nhật các options hiện có
            foreach (var updatingOption in updatingOptions)
            {
                var existingOption = existingOptions.FirstOrDefault(eo => eo.OptionId == updatingOption.OptionId);
                if (existingOption != null)
                {
                    existingOption.OptionText = updatingOption.OptionText;
                    existingOption.IsCorrect = updatingOption.IsCorrect;
                    //existingOption.UpdatedAt = DateTime.Now;
                }
            }
            
            // Thêm các options mới
            if (newOptions.Any())
            {
                var newOptionEntities = newOptions.Select(o => new Option
                {
                    QuestionId = questionDTO.QuestionId,
                    OptionText = o.OptionText,
                    IsCorrect = o.IsCorrect,
                    //CreatedAt = DateTime.Now,
                    //UpdatedAt = DateTime.Now,
                    //Status = o.Status
                }).ToList();
                
                await _context.Options.AddRangeAsync(newOptionEntities);
            }
            
            // Lưu tất cả thay đổi vào database
            await _context.SaveChangesAsync();
        }
        
        // Phương thức lấy tất cả câu hỏi kèm theo các options
        public async Task<List<QuestionsDTO>> GetAllQuestionsWithOptionsAsync()
        {
            // Lấy tất cả câu hỏi từ database
            var questions = await _context.Questions.ToListAsync();
            var result = new List<QuestionsDTO>();
            
            foreach (var question in questions)
            {
                // Lấy options cho mỗi câu hỏi
                var options = await _context.Options
                    .Where(o => o.QuestionId == question.QuestionId)
                    .ToListAsync();
                    
                // Tạo QuestionsDTO
                var questionDTO = new QuestionsDTO
                {
                    QuestionId = question.QuestionId,
                    QuizId = question.QuizId,
                    QuestionName = question.QuestionName,
                    Type = question.Type,
                    Options = options.Select(o => new OptionsDTO
                    {
                        OptionId = o.OptionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect,
                        QuestionId = o.QuestionId
                    }).ToList()
                };
                
                result.Add(questionDTO);
            }
            
            return result;
        }
    }
}
