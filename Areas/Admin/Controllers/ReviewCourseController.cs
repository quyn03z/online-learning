using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using OnlineLearning.Data;
using OnlineLearning.Enums;
using OnlineLearning.Hubs;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Services.Implementations;
using OnlineLearning.Services.Interfaces;
using OnlineLearning.Services.Interfaces.Admin;
using static System.Net.WebRequestMethods;

namespace OnlineLearning.Areas.Admin.Controllers
{
    [Authorize(Roles = nameof(RoleType.ADMIN))]
    [Area("Admin")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class ReviewCourseController : Controller
    {
        private readonly ICourseService _courseService;
        protected readonly OnlLearnDBContext _context;
        private readonly INotificationService _notificationService;
        private readonly IUserService _userService;
        private readonly Services.Interfaces.ILanguageService _languageService;
        private readonly ILevelService _levelService;
        private readonly ICategoryService _categoryService;
        private readonly ICourseImageService _courseImageService;
        private readonly ICourseCategoriesService _courseCategoriesService;
        private readonly IHubContext<CourseNotificationHub> _hubContext;
        private readonly IEmailService _emailService;
        private readonly IReviewService _reviewService;


        public ReviewCourseController(IReviewService reviewService,IEmailService emailService, IHubContext<CourseNotificationHub> hubContext, IUserService userService, ICourseService courseService, OnlLearnDBContext context, INotificationService notificationService, Services.Interfaces.ILanguageService languageService, ILevelService levelService, ICategoryService categoryService, ICourseImageService courseImageService, ICourseCategoriesService courseCategoriesService)
        {
            _context = context;
            _courseService = courseService;
            _notificationService = notificationService;
            _languageService = languageService;
            _levelService = levelService;
            _categoryService = categoryService;
            _courseImageService = courseImageService;
            _courseCategoriesService = courseCategoriesService;
            _userService = userService;
            _hubContext = hubContext;
            _emailService = emailService;
            _reviewService = reviewService;
        }
        


        public async Task<IActionResult> Index()
        {
            var userIdString = HttpContext.Session.GetString("UserId");

            //// Chưa đăng nhập
            if (string.IsNullOrEmpty(userIdString))
            {
                return RedirectToAction("Index", "Login", new { area = "" });// Chỉ định area = null để chuyển hướng ra khỏi area hiện tại
            }

            var user = await _userService.GetUserByIdAsync(long.Parse(userIdString));

            ViewBag.User = user;
            ViewBag.Notifications = await _notificationService.GetAllNotificationsIsNotClear() ?? new List<Notification>();
            ViewBag.NotificationsCount = (await _notificationService.GetAllNotificationsIsNotRead()).Count;
            var listCourse = await _courseService.GetCoursesListNotApproveYetAsync();
            return View("ListReviewCourse", listCourse);
        }


        [Route("Admin/ReviewCourse/Detail/{courseId}")]
        //[HttpGet("{courseId}")]
        public async Task<IActionResult> DetailAsync(long courseId)
        {
            var userIdString = HttpContext.Session.GetString("UserId");

            //// Chưa đăng nhập
            if (string.IsNullOrEmpty(userIdString))
            {
                return RedirectToAction("Index", "Login", new { area = "" });// Chỉ định area = null để chuyển hướng ra khỏi area hiện tại
            }
            try {
                var user = await _userService.GetUserByIdAsync(long.Parse(userIdString));

                ViewBag.User = user;
                //set notification is readed
                await _notificationService.IsReaded(courseId, false);
            }catch(Exception ex) 
            {
                if(ex.Message.Equals("NotFound"))
                {
                    return NotFound();
                }
            }
            ViewBag.NotificationsCount = (await _notificationService.GetAllNotificationsIsNotRead()).Count;
            ViewBag.Notifications = await _notificationService.GetAllNotificationsIsNotClear() ?? new List<Notification>();
            if (courseId != 0)
            {
                var course = await _courseService.GetCourseByIdAsync(courseId);

                if (course == null)
                {
                    return NotFound();
                }

                var selectedCategoryId = await _courseCategoriesService.GetCategoryIdsByCourseIdAsync(courseId);
                var listExistingCourseImage = await _courseImageService.GetListImgByCourseIdAsync(courseId);
                var creator = await _userService.GetUserByIdAsync(course.Creator);
                var adminId = HttpContext.Session.GetString("UserId"); // Lấy AdminId từ Session

                var courseDto = new Admin_ReviewCourseDto
                {
                    CourseId = course.CourseId,
                    CourseName = course.CourseName,
                    CourseUrls = listExistingCourseImage,
                    Description = course.Description,
                    Price = course.Price,
                    Discount = course.Discount,
                    LanguageId = course.LanguageId,
                    LevelId = course.LevelId,
                    CategoryId = selectedCategoryId,
                    CreatorName = creator?.FullName,
                    AdminId = Int32.Parse(adminId) //để tạm
                };

                var courseLevels = await _levelService.GetAllLevelAysnc();
                var courseLanguage = await _languageService.GetAllLanguageAysnc();

                var allCategories = await _categoryService.GetAllCategoryAysnc();
                ViewBag.CourseLevels = new SelectList(courseLevels, "LevelId", "LevelName", course.LevelId);
                ViewBag.CourseLanguages = new SelectList(courseLanguage, "LanguageId", "LanguageName", course.LanguageId);

                ViewData["CourseCategories"] = new SelectList(allCategories, "CategoryId", "CategoryName", selectedCategoryId);
                return View("DetailReviewCourse", courseDto);
            }
            else
            {
                TempData["errorMsg"] = "Course does not exist";
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        
        public async Task<IActionResult> ApproveCourseAsync(Admin_ReviewCourseDto model)
        {
            if (ModelState.IsValid) { 
                return View(model);
            }
            var course = await _context.Courses.FindAsync(model.CourseId);
            if (course == null) return NotFound();
            course.Status = Enums.CourseStatus.Approved; // Giả sử có cột Status

            var adminReviewCourse = new AdminReviewCourse
            {
                CourseId = model.CourseId,
                AdminId = model.AdminId,
                Status = Enums.ReviewStatus.Approved,
                ReviewNotes = model.ReviewNote ?? "",
                ReviewedAt = DateTime.UtcNow,
            };
            await _context.AdminReviewCourses.AddAsync(adminReviewCourse);
            await _context.SaveChangesAsync();
            var creator = await  _userService.GetUserByIdAsync(course.Creator);
            if (creator != null)
            {
                // Lấy review mới nhất (vừa lưu)
                var latestReview = await _reviewService.GetLatestReviewByCourseId(course.CourseId);
                string reason = latestReview?.ReviewNotes;

                // Gửi email thông báo
                await _emailService.SendResponseReviewCourse(creator.Email, course.CourseName, true, reason);
                TempData["Message"] = "You are Approve the course successfully!";
                return RedirectToAction("Index");
            } else
            {
                TempData["Error"] = "Creator not found!";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        
        public async Task<IActionResult> RejectCourseAsync(Admin_ReviewCourseDto model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            var course = await _context.Courses.FindAsync(model.CourseId);
            if (course == null) return NotFound();
            course.Status = Enums.CourseStatus.Rejected;

            var adminReviewCourse = new AdminReviewCourse
            {
                CourseId = model.CourseId,
                AdminId = model.AdminId,
                Status = Enums.ReviewStatus.Rejected,
                ReviewNotes = model.ReviewNote,
                ReviewedAt = DateTime.UtcNow,
            };
            await _context.AdminReviewCourses.AddAsync(adminReviewCourse);

            await _context.SaveChangesAsync();
            var creator = await _userService.GetUserByIdAsync(course.Creator);
            if (creator != null)
            {
                // Lấy review mới nhất (vừa lưu)
                var latestReview = await _reviewService.GetLatestReviewByCourseId(course.CourseId);
                string reason = latestReview?.ReviewNotes;

                // Gửi email thông báo
                await _emailService.SendResponseReviewCourse(creator.Email, course.CourseName, false, reason);
                TempData["Message"] = "You are Reject the course successfully!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = "Creator not found!";
                return RedirectToAction("Index");
            }


        }
    }
}
