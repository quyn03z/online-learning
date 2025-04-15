using Microsoft.AspNetCore.Mvc;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.CourseModels.LessonModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Areas.Mentor.Controllers
{
	[Area("Mentor")]
	public class LessonQuizController : Controller
	{
		private readonly IModuleService _moduleService;
		private readonly ILessonService _lessonService;
		private readonly IQuizService _quizService;

		public LessonQuizController(IModuleService moduleService, ILessonService lessonService, IQuizService quizService)
		{
			_moduleService = moduleService;
			_lessonService = lessonService;
			_quizService = quizService;
		}

		public async Task<IActionResult> Index(int moduleNumber, string moduleName, long courseId)
		{
			var module = await _moduleService.GetModuleAsync(courseId, moduleNumber);

			var listLesson = await _lessonService.GetAllLessonByModuleIdAsync(module.ModuleId);
			var listQuiz = await _quizService.GetQuizzesByModuleIdAsync(module.ModuleId);

			var model = new ModuleDto
			{
				ModuleNumber = moduleNumber,
				ModuleName = moduleName,
				CourseId = courseId,
				Lessons = listLesson.ToList(),
				Quizzes = listQuiz.ToList()
			};

			return View(model);
		}


		public async Task<IActionResult> UpdateModuleName(ModuleDto model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			if (model.ModuleName.Length > 255)
			{
				ModelState.AddModelError("ModuleName", "ModuleName không được vượt quá 255 ký tự!");
			}

			var module = await _moduleService.GetModuleAsync(model.CourseId, model.ModuleNumber);
			if (module == null)
			{
				return NotFound();
			}
			module.ModuleName = model.ModuleName;
			await _moduleService.UpdateModuleAsync(module);
			TempData["Success"] = "Update thành công!";

			return RedirectToAction("Index", new { moduleNumber = module.ModuleNumber, moduleName = module.ModuleName, courseId = module.CourseId });
		}

		public async Task<IActionResult> DeleteModule(int moduleNumber, long courseId)
		{
			var module = await _moduleService.GetModuleAsync(courseId, moduleNumber);
			if (module == null)
			{
				return NotFound();
			}

			await _moduleService.DeleteModuleAsync(module);

			return RedirectToAction("CourseEdit", "Course", new { id = courseId });
		}



		[HttpGet]
		public async Task<IActionResult> AddLessonAsync(int ModuleNumber, string ModuleName, long CourseId)
		{
			var module = await _moduleService.GetModuleAsync(CourseId, ModuleNumber);

			int nextLessonNumber = await _lessonService.GetNextLessonNumberAsync(module.ModuleId);
			var model = new LessonDTO
			{
				CourseId = CourseId,
				ModuleNumber = ModuleNumber,
				ModuleName = ModuleName,
				LessonNumber = nextLessonNumber
			};

			return View(model);
		}



		[HttpPost]
		public async Task<IActionResult> AddLessonAsync(LessonDTO model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var module = await _moduleService.GetModuleAsync(model.CourseId, model.ModuleNumber);

			var lesson = new Lesson
			{
				ModuleId = module.ModuleId,
				LessonNumber = model.LessonNumber,
				LessonName = model.LessonName,
				LessonContent = model.LessonContent,
				LessonVideo = model.LessonVideo,
				CreatedAt = DateTime.Now
			};

			await _lessonService.AddLessonAsync(lesson);
			TempData["Success"] = "Lesson mới đã được thêm vào!";

			return RedirectToAction("Index", new { moduleNumber = module.ModuleNumber, moduleName = module.ModuleName, courseId = model.CourseId });
		}

		/* UPDATE LESSON: Redirect to page update */
		[HttpGet]
		public async Task<IActionResult> UpdateLessonAsync(int lessonId)
		{
			var lesson = await _lessonService.GetLessonByIdAsync(lessonId);
			if (lesson == null) return NotFound();

			var module = await _moduleService.GetModuleByIdAsync(lesson.ModuleId);
			if (module == null) return NotFound();

			var lessonDto = new LessonDTO
			{
				CourseId = module.CourseId,
				ModuleNumber = module.ModuleNumber,
				ModuleName = module.ModuleName,
				LessonNumber = lesson.LessonNumber,
				LessonName = lesson.LessonName,
				LessonContent = lesson.LessonContent,
				LessonVideo = lesson.LessonVideo
			};
			ViewBag.LessonId = lessonId;
			return View(lessonDto);
		}

		/* UPDATE LESSON: process update */
		[HttpPost]
		public async Task<IActionResult> UpdateLessonAsync(LessonDTO lessonDTO, int lessonId)
		{
			if (!ModelState.IsValid)
			{
				return View(lessonDTO);
			}
			var currentLesson = await _lessonService.GetLessonByIdAsync(lessonId);
			if (currentLesson == null) return NotFound();

			var module = await _moduleService.GetModuleByIdAsync(currentLesson.ModuleId);
			if (module == null) return NotFound();

			//Update
			currentLesson.LessonNumber = lessonDTO.LessonNumber;
			currentLesson.LessonName = lessonDTO.LessonName;
			currentLesson.LessonContent = lessonDTO.LessonContent;
			currentLesson.LessonVideo = lessonDTO.LessonVideo;
			currentLesson.UpdatedAt = DateTime.Now;

			var result = await _lessonService.UpdateLessonAsync(currentLesson);
			if (!result)
			{
				TempData["Fail"] = "Lỗi khi cập nhật lesson!";
				return View(lessonDTO);
			}
			TempData["Success"] = "Lesson đã được cập nhật thành công!";
			return RedirectToAction("Index", new { moduleNumber = module.ModuleNumber, moduleName = module.ModuleName, courseId = module.CourseId });
		}

		/* DELETE LESSON: status => HIDED */
		[HttpPost]
		public async Task<IActionResult> DeleteLessonAsync(int lessonId)
		{
			var lessonDelete = await _lessonService.GetLessonByIdAsync(lessonId);
			if (lessonDelete == null) return NotFound();

			var module = await _moduleService.GetModuleByIdAsync(lessonDelete.ModuleId);
			if (module == null) return NotFound();

			// soft delete
			lessonDelete.Status = Enums.CommonStatus.Hided;
			var result = await _lessonService.UpdateLessonAsync(lessonDelete);
			if (!result)
			{
				TempData["Fail"] = "Lỗi khi xóa lesson";
			}
			TempData["Success"] = "Lesson đã được xóa!";
			return RedirectToAction("Index", new { moduleNumber = module.ModuleNumber, moduleName = module.ModuleName, courseId = module.CourseId });
		}

		/* UPDATE QUIZ: Hiển thị form cập nhật quiz */
		[HttpGet]
		public async Task<IActionResult> UpdateQuiz(long quizId)
		{
			var quiz = await _quizService.GetQuizByIdAsync(quizId);
			if (quiz == null) return NotFound();

			// Lấy thông tin module từ quiz
			var module = await _moduleService.GetModuleByIdAsync(quiz.ModuleId);
			if (module == null) return NotFound();

			// Chuẩn bị dữ liệu cho view
			ViewBag.ModuleNumber = module.ModuleNumber;
			ViewBag.ModuleName = module.ModuleName;
			ViewBag.CourseId = module.CourseId;

			// Nếu thời gian quiz được lưu bằng giây, chuyển đổi lại thành phút để hiển thị
			if (quiz.QuizTime > 0 && quiz.QuizTime % 60 == 0)
			{
				quiz.QuizTime = quiz.QuizTime / 60;
				ViewBag.TimeUnit = "minutes";
			}
			else
			{
				ViewBag.TimeUnit = "seconds";
			}

			return View("UpdateQuiz", quiz);
		}

		/* UPDATE QUIZ: Xử lý cập nhật quiz */
		[HttpPost]
		public async Task<IActionResult> UpdateQuiz(QuizDTO quizDTO)
		{
			if (!ModelState.IsValid)
			{
				return View(quizDTO);
			}

			// Chuyển đổi thời gian nếu đơn vị là phút
			if (quizDTO.TimeUnit == "minutes")
			{
				quizDTO.QuizTime = quizDTO.QuizTime * 60; // Chuyển phút sang giây
			}

			await _quizService.UpdateQuizAsync(quizDTO);
			
			// Lấy thông tin module từ quizDTO
			var module = await _moduleService.GetModuleByIdAsync(quizDTO.ModuleId);
			if (module == null) return NotFound();

			TempData["Success"] = "Quiz has been updated successfully!";
			return RedirectToAction("Index", new { moduleNumber = module.ModuleNumber, moduleName = module.ModuleName, courseId = module.CourseId });
		}

		/* DELETE QUIZ: Xử lý xóa quiz */
		[HttpPost]
		public async Task<IActionResult> DeleteQuiz(long quizId)
		{
			var quiz = await _quizService.GetQuizByIdAsync(quizId);
			if (quiz == null) return NotFound();

			// Lấy thông tin module từ quiz
			var module = await _moduleService.GetModuleByIdAsync(quiz.ModuleId);
			if (module == null) return NotFound();

			// Xóa quiz bằng ID thay vì tạo entity mới
			await _quizService.DeleteQuizByIdAsync(quizId);
			
			TempData["Success"] = "Quiz was successfully deleted!";
			return RedirectToAction("Index", new { moduleNumber = module.ModuleNumber, moduleName = module.ModuleName, courseId = module.CourseId });
		}
	}
}
