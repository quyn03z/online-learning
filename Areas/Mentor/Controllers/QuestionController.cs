using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using OnlineLearning.Enums;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Models.ViewModels;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Areas.Mentor.Controllers
{
    [Area("Mentor")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly IModuleService _moduleService;
        private readonly ILessonService _lessonService;

        public QuestionController(IQuestionService questionService, IModuleService moduleService, ILessonService lessonService)
        {
            _questionService = questionService;
            _moduleService = moduleService;
            _lessonService = lessonService;
        }
        public async Task<IActionResult> QuestionsView(long quizId = 0)
        {
            // Khởi tạo model cho view
            var model = new QuestionViewModel();

            // Lấy quizDTO từ Session (nếu có)
            QuizDTO quizDTO = null;
            var quizData = HttpContext.Session.GetString("Quiz");
            if (!string.IsNullOrEmpty(quizData))
            {
                quizDTO = JsonConvert.DeserializeObject<QuizDTO>(quizData);
                // Nếu quizId không được cung cấp trong tham số, sử dụng quizId từ session
                if (quizId == 0 && quizDTO != null)
                {
                    quizId = quizDTO.QuizId;
                }
            }

            // Lấy danh sách câu hỏi và options từ database theo quizId
            if (quizId > 0)
            {
                var questions = await _questionService.GetAllQuestionsWithOptionsByQuizIdAsync(quizId);
                model.Questions = questions;
                model.Quiz = quizDTO ?? new QuizDTO { QuizId = quizId };
                
                // Lấy thông tin của module từ quizId nếu có
                if (model.Quiz != null && model.Quiz.ModuleId > 0)
                {
                    // Lấy thông tin của module
                    var module = await _moduleService.GetModuleByIdAsync(model.Quiz.ModuleId);
                    if (module != null)
                    {
                        model.ModuleNumber = module.ModuleNumber;
                        model.ModuleName = module.ModuleName;
                        model.CourseId = module.CourseId;
                    }
                }
            }
            else
            {
                // Không có quizId, trả về danh sách rỗng
                model.Questions = new List<QuestionWithOptionsDTO>();
                model.Quiz = quizDTO;
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> CreateQuestion([FromForm] QuestionsDTO questionsDTO, [FromForm] List<OptionsDTO> optionsDTO, [FromForm] QuizDTO quizDTO)
        {
            // Kiểm tra dữ liệu đầu vào
            //if (!ModelState.IsValid || optionsDTO == null || !optionsDTO.Any())
            //{
            //    return View("QuestionsView", questionsDTO);
            //}

            // Đếm số lượng câu trả lời đúng
            int correctAnswerCount = optionsDTO.Count(o => o.IsCorrect);

            // Xác định type của question dựa trên số lượng câu trả lời đúng
            questionsDTO.Type = correctAnswerCount == 1 ? QuestionType.Radio : QuestionType.CheckBox;

            // Gọi service để lưu question và options vào database
            await _questionService.CreateQuestionWithOptionsAsync(questionsDTO, optionsDTO, quizDTO);

            // Chuyển hướng về trang danh sách với quizId
            return RedirectToAction("QuestionsView", new { quizId = questionsDTO.QuizId });
        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteQuestion(long questionId)
        {
            try
            {
                // Lấy thông tin của câu hỏi để lấy QuizId trước khi xóa
                var question = await _questionService.GetQuestionWithOptionsById(questionId);
                var quizId = question?.QuizId ?? 0;
                
                await _questionService.DeleteQuestionAsync(questionId);
                TempData["SuccessMessage"] = "Question deleted successfully!";
                
                // Chuyển hướng về trang danh sách với QuizId
                return RedirectToAction("QuestionsView", new { quizId });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Lỗi khi xóa câu hỏi: {ex.Message}";
                return RedirectToAction("QuestionsView");
            }
        }
        
        // Phương thức hiển thị form edit với dữ liệu của question và options
        [HttpGet]
        public async Task<IActionResult> GetQuestionById(long questionId)
        {
            try
            {
                // Lấy thông tin câu hỏi và options từ database
                var questionWithOptions = await _questionService.GetQuestionWithOptionsById(questionId);
                if (questionWithOptions == null)
                {
                    return NotFound();
                }
                
                // Chuyển đổi từ QuestionWithOptionsDTO sang QuestionsDTO
                var questionsDTO = new QuestionsDTO
                {
                    QuestionId = questionWithOptions.QuestionId,
                    QuizId = questionWithOptions.QuizId,
                    QuestionName = questionWithOptions.QuestionName,
                    Type = questionWithOptions.Type,
                    Options = questionWithOptions.Options
                };
                
                // Trả về partial view với dữ liệu câu hỏi
                return PartialView("_EditQuestions", questionsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi khi lấy thông tin câu hỏi: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditQuestion(long questionId)
        {
            try
            {
                // Lấy thông tin câu hỏi và options từ database
                var questionWithOptions = await _questionService.GetQuestionWithOptionsById(questionId);
                if (questionWithOptions == null)
                {
                    TempData["ErrorMessage"] = "Không tìm thấy câu hỏi";
                    return RedirectToAction("QuestionsView");
                }
                
                // Chuyển đổi từ QuestionWithOptionsDTO sang QuestionsDTO
                var questionsDTO = new QuestionsDTO
                {
                    QuestionId = questionWithOptions.QuestionId,
                    QuizId = questionWithOptions.QuizId,
                    QuestionName = questionWithOptions.QuestionName,
                    Type = questionWithOptions.Type,
                    Options = questionWithOptions.Options
                };
                
                // Trả về view
                return View("_EditQuestions", questionsDTO);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Lỗi khi lấy thông tin câu hỏi: {ex.Message}";
                return RedirectToAction("QuestionsView");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuestion([FromForm] QuestionsDTO questionsDTO, [FromForm] List<OptionsDTO> optionsDTO)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (!ModelState.IsValid || optionsDTO == null || !optionsDTO.Any())
                {
                    return View("QuestionsView", questionsDTO);
                }

                // Đếm số lượng câu trả lời đúng
                int correctAnswerCount = optionsDTO.Count(o => o.IsCorrect);

                // Xác định type của question dựa trên số lượng câu trả lời đúng
                questionsDTO.Type = correctAnswerCount == 1 ? QuestionType.Radio : QuestionType.CheckBox;

                // Gọi service để cập nhật question và options
                await _questionService.UpdateQuestionWithOptionsAsync(questionsDTO, optionsDTO);

                TempData["SuccessMessage"] = "Question updated successfully!";
                
                // Chuyển hướng về trang danh sách với QuizId
                return RedirectToAction("QuestionsView", new { quizId = questionsDTO.QuizId });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Lỗi khi cập nhật câu hỏi: {ex.Message}";
                return RedirectToAction("QuestionsView");
            }
        }
    }
}
