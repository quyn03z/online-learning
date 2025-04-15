using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Models.ViewModels;
using OnlineLearning.Services.Implementations;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Areas.Mentor.Controllers
{
    [Area("Mentor")]
    public class QuizController : Controller
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        // Hiển thị form tạo quiz

        public async Task<IActionResult> Create(int ModuleNumber, string ModuleName, int CourseId)
        {
            // Lấy thông tin Module từ ModuleNumber và CourseId
            var moduleService = HttpContext.RequestServices.GetService<IModuleService>();
            long moduleId = 0;
            
            if (moduleService != null)
            {
                var module = await moduleService.GetModuleAsync(CourseId, ModuleNumber);
                if (module != null)
                {
                    moduleId = module.ModuleId;
                }
            }
            
            var model = new QuizDTO
            {
                ModuleId = moduleId
            };
            
            // Lưu thông tin bổ sung vào ViewBag để sử dụng trong view
            ViewBag.ModuleNumber = ModuleNumber;
            ViewBag.ModuleName = ModuleName;
            ViewBag.CourseId = CourseId;
            
            return View(model);
        }


        public async Task<IActionResult> CreateQuiz(QuizDTO quizDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", quizDTO);
            }

             var quiz = await _quizService.CreateQuizAsync(quizDTO);



            // Lưu quizDTO vào Session (chuyển thành JSON để dễ lưu trữ)
            HttpContext.Session.SetString("Quiz", JsonConvert.SerializeObject(quiz));

            return RedirectToAction("QuestionsView", "Question");
        }
    }
}
