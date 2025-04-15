using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.Host;
using Microsoft.EntityFrameworkCore;
using OnlineLearning.Enums;
using OnlineLearning.Hubs;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Services.Interfaces;
using OnlineLearning.Services.Interfaces.Admin;

namespace OnlineLearning.Areas.Mentor.Controllers
{
    [Authorize(Roles = nameof(RoleType.MENTOR))]
    [Area("Mentor")]
    public class CourseController : Controller
    {
        private readonly Services.Interfaces.ILanguageService _languageService;
        private readonly ILevelService _levelService;
        private readonly ICourseService _courseService;
        private readonly ICategoryService _categoryService;
        private readonly ICourseImageService _courseImageService;
        private readonly ICourseCategoriesService _courseCategoriesService;
        private readonly IModuleService _moduleService;
        private readonly INotificationService _notify;
        private readonly IWebHostEnvironment _environment;
        private readonly IHubContext<CourseNotificationHub> _hubContext;

        public CourseController(Services.Interfaces.ILanguageService languageService, ILevelService levelService, ICourseService courseService, ICategoryService categoryService, ICourseImageService courseImageService, ICourseCategoriesService courseCategoriesService, IModuleService moduleService, INotificationService notify, IWebHostEnvironment environment, IHubContext<CourseNotificationHub> hubContext)
        {
            _languageService = languageService;
            _levelService = levelService;
            _courseService = courseService;
            _categoryService = categoryService;
            _courseImageService = courseImageService;
            _courseCategoriesService = courseCategoriesService;
            _moduleService = moduleService;
            _notify = notify;
            _environment = environment;
            _hubContext = hubContext;
        }

        public async Task<IActionResult> Index()
        {
            //var userIdString = HttpContext.Session.GetString("UserId");

            //if (string.IsNullOrEmpty(userIdString))
            //{
            //    return RedirectToAction("Index", "Login", new { area = "" });// Chỉ định area = null để chuyển hướng ra khỏi area hiện tại
            //}
            /////////////////-> Ko cần kiểm tra đăng nhạp. Ko có quyền thì cho vào access deny luôn
            string userId = HttpContext.Session.GetString("UserId");
           
            var listAllCourse = await _courseService.GetAllCourseByMentorAsync(long.Parse(userId));
			return View(listAllCourse.ToList());
		}




        public async Task<IActionResult> AddCourse()
        {
            var userIdString = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(userIdString))
            {
                return RedirectToAction("Index", "Login", new { area = "" });// Chỉ định area = null để chuyển hướng ra khỏi area hiện tại
            }

            var courseLevels = await _levelService.GetAllLevelAysnc();
            var courseLanguage = await _languageService.GetAllLanguageAysnc();
            var courseCategories = await _categoryService.GetAllCategoryAysnc();



            ViewBag.CourseLevels = new SelectList(courseLevels, "LevelId", "LevelName");
            ViewBag.CourseLanguages = new SelectList(courseLanguage, "LanguageId", "LanguageName");
            ViewBag.CourseCategories = new SelectList(courseCategories, "CategoryId", "CategoryName");

            return View(new CourseDto());
        }


        [HttpPost]
        public async Task<IActionResult> UploadImages(IFormFile[] images)
        {
            if (images == null || images.Length == 0)
            {
                return Json(new { success = false, message = "No images uploaded." });
            }

            if (images.Length > 4)
            {
                return Json(new { success = false, message = "You can only upload a maximum of 4 images." });
            }

            var imagePaths = new List<string>();
            foreach (var file in images)
            {
                if (file != null && file.Length > 0)
                {
                    // Validate file type
                    if (!file.ContentType.StartsWith("image/"))
                    {
                        return Json(new { success = false, message = "Please upload only image files." });
                    }

                    // Create a unique file name
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(_environment.WebRootPath, "uploads", fileName);

                    // Ensure the uploads directory exists
                    var uploadsDir = Path.Combine(_environment.WebRootPath, "uploads");
                    if (!Directory.Exists(uploadsDir))
                    {
                        Directory.CreateDirectory(uploadsDir);
                    }

                    // Save the file to the server
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    // Add the image path to the list
                    imagePaths.Add($"/uploads/{fileName}");
                }
            }

            return Json(new { success = true, imagePaths });
        }

        [HttpPost]
        public IActionResult DeleteImage([FromBody] DeleteImageRequest request)
        {
            try
            {
                // Validate the image path
                if (string.IsNullOrEmpty(request.ImagePath))
                {
                    return Json(new { success = false, message = "Invalid image path." });
                }

                // Construct the full file path
                var filePath = Path.Combine(_environment.WebRootPath, request.ImagePath.TrimStart('/'));

                // Check if the file exists and delete it
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                    return Json(new { success = true });
                }

                return Json(new { success = false, message = "Image not found." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Error deleting image: {ex.Message}" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse(CourseDto model)
        {
            var userIdString = HttpContext.Session.GetString("UserId");
            long.TryParse(userIdString, out long userId);

            if (model.CourseName.Length > 255)
            {
                ModelState.AddModelError("CourseName", "CourseName không được vượt quá 255 ký tự!");
            }

            // Deserialize the uploaded image paths
            List<string> imagePaths = string.IsNullOrEmpty(model.UploadedImagePaths)
                ? new List<string>()
                : System.Text.Json.JsonSerializer.Deserialize<List<string>>(model.UploadedImagePaths);

            if (!imagePaths.Any())
            {
                ModelState.AddModelError("UploadedImagePaths", "Please upload at least one image.");
            }

            if (!ModelState.IsValid)
            {
                var courseLevels = await _levelService.GetAllLevelAysnc();
                var courseLanguages = await _languageService.GetAllLanguageAysnc();
                var courseCategories = await _categoryService.GetAllCategoryAysnc();

                ViewBag.CourseLevels = new SelectList(courseLevels, "LevelId", "LevelName");
                ViewBag.CourseLanguages = new SelectList(courseLanguages, "LanguageId", "LanguageName");
                ViewBag.CourseCategories = new SelectList(courseCategories, "CategoryId", "CategoryName");

                return View(model);
            }

            // Create a new course entity
            var newCourse = new Course
            {
                CourseName = model.CourseName,
                Description = model.Description,
                Price = model.Price,
                Discount = model.Discount,
                Creator = userId,
                Acceptor = null,
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                PublishedAt = null,
                DeletedAt = null,
                StudyTime = null,
                LanguageId = model.LanguageId,
                LevelId = model.LevelId,
                Status = CourseStatus.Pending,
            };

            await _courseService.AddCourseAsync(newCourse);

            // Add course category
            var newCourseCategory = new CourseCategory
            {
                CourseId = newCourse.CourseId,
                CategoryId = model.CategoryId,
                CreatedAt = DateTime.Now
            };

            await _courseCategoriesService.AddCourseCategoryAsync(newCourseCategory);

            // Save the image paths to the database
            foreach (var imageUrl in imagePaths)
            {
                var newCourseImage = new CourseImageUrl
                {
                    CourseId = newCourse.CourseId,
                    Url = imageUrl
                };
                await _courseImageService.AddCourseImageUrlAsync(newCourseImage);
            }

            // Add notification
            var notification = new Notification
            {
                CourseId = newCourse.CourseId,
                CourseName = newCourse.CourseName,
                CourseUrl = imagePaths.FirstOrDefault(),
                CreatedAt = DateTime.Now,
                IsRead = false,
                NotificationType = NotificationType.Add
            };

            await _notify.AddNotification(notification);

            // Send notification to admins via SignalR
            await _hubContext.Clients.Group("Admins").SendAsync("ReceiveCourseNotification",
                new
                {
                    CourseId = newCourse.CourseId,
                    CourseName = newCourse.CourseName,
                    CourseUrl = notification.CourseUrl,
                    CreatedAt = newCourse.CreatedAt
                });

            TempData["Success"] = "Khóa học mới đã được thêm vào!";

            return RedirectToAction("Index");
        }
    


    [HttpGet("Course/HiddenCourse/{courseId}")]
        public async Task<IActionResult> HiddenCourse(long courseId)
        {
            var hiddenCourse = await _courseService.GetCourseByIdAsync(courseId);
            if (hiddenCourse == null)
            {
                return NotFound();
            }

            hiddenCourse.Status = CourseStatus.Draft;
            await _courseService.UpdateCourseAsync(hiddenCourse);

            TempData["Success"] = "Cập nhật thành công!";

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> CourseEdit(long id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            var selectedCategoryId = await _courseCategoriesService.GetCategoryIdsByCourseIdAsync(id);
            var existingCourseImages = await _courseImageService.GetListImgByCourseIdAsync(id); // Assuming this method exists to get all images

            var courseDto = new CourseEditDto
            {
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                ExistingImageUrls = existingCourseImages.Select(img => img.Url).ToList(), // Populate existing image URLs
                Description = course.Description,
                Price = course.Price,
                Discount = course.Discount,
                LanguageId = course.LanguageId,
                LevelId = course.LevelId,
                OldCategoryId = selectedCategoryId,
            };

            var courseLevels = await _levelService.GetAllLevelAysnc();
            var courseLanguage = await _languageService.GetAllLanguageAysnc();
            var allCategories = await _categoryService.GetAllCategoryAysnc();
            var allModuleByCourseId = await _moduleService.GetAllModuleByCourseId(id);

            ViewBag.Modules = allModuleByCourseId;
            ViewBag.CourseLevels = new SelectList(courseLevels, "LevelId", "LevelName", course.LevelId);
            ViewBag.CourseLanguages = new SelectList(courseLanguage, "LanguageId", "LanguageName", course.LanguageId);
            ViewData["CourseCategories"] = new SelectList(allCategories, "CategoryId", "CategoryName", selectedCategoryId);

            return View("editCourse", courseDto);
        }


        [HttpPost]
        public async Task<IActionResult> EditCourse(CourseEditDto model)
        {
            var userIdString = HttpContext.Session.GetString("UserId");
            long.TryParse(userIdString, out long userId);

            if (model.CourseName.Length > 255)
            {
                ModelState.AddModelError("CourseName", "CourseName không được vượt quá 255 ký tự!");
            }

            // Deserialize the uploaded image paths
            List<string> imagePaths = string.IsNullOrEmpty(model.UploadedImagePaths)
                ? new List<string>()
                : System.Text.Json.JsonSerializer.Deserialize<List<string>>(model.UploadedImagePaths);

            if (!imagePaths.Any())
            {
                ModelState.AddModelError("UploadedImagePaths", "Please upload at least one image.");
            }

            if (!ModelState.IsValid)
            {
                var courseLevels = await _levelService.GetAllLevelAysnc();
                var courseLanguages = await _languageService.GetAllLanguageAysnc();
                var courseCategories = await _categoryService.GetAllCategoryAysnc();

                ViewBag.CourseLevels = new SelectList(courseLevels, "LevelId", "LevelName");
                ViewBag.CourseLanguages = new SelectList(courseLanguages, "LanguageId", "LanguageName");
                ViewBag.CourseCategories = new SelectList(courseCategories, "CategoryId", "CategoryName");

                return View(model);
            }

            var existingCourse = await _courseService.GetCourseByIdAsync(model.CourseId);
            if (existingCourse == null)
            {
                return NotFound();
            }

            // Update course details
            existingCourse.CourseName = model.CourseName;
            existingCourse.Description = model.Description;
            existingCourse.Price = model.Price;
            existingCourse.Discount = model.Discount;
            existingCourse.LanguageId = model.LanguageId;
            existingCourse.LevelId = model.LevelId;
            existingCourse.Status = CourseStatus.Pending;
            existingCourse.UpdatedAt = DateTime.Now;

            await _courseService.UpdateCourseAsync(existingCourse);

            // Update course category
            var existingCourseCategory = await _courseCategoriesService.GetByCourseIdAsync(model.CourseId, model.OldCategoryId.Value);
            if (existingCourseCategory != null)
            {
                await _courseCategoriesService.DeleteCourseCategoryAsync(existingCourseCategory);
            }
            var newCourseCategory = new CourseCategory
            {
                CourseId = model.CourseId,
                CategoryId = model.CategoryId,
                CreatedAt = DateTime.Now
            };
            await _courseCategoriesService.AddCourseCategoryAsync(newCourseCategory);

            // Delete existing images from the database
            var existingImages = await _courseImageService.GetListImgByCourseIdAsync(model.CourseId);
            foreach (var image in existingImages)
            {
                await _courseImageService.DeleteCourseImageUrlAsync(image);
            }

            // Save the new image paths to the database
            foreach (var imageUrl in imagePaths)
            {
                var newCourseImage = new CourseImageUrl
                {
                    CourseId = model.CourseId,
                    Url = imageUrl
                };
                await _courseImageService.AddCourseImageUrlAsync(newCourseImage);
            }

            // Add notification
            var notification = new Notification
            {
                CourseId = existingCourse.CourseId,
                CourseName = existingCourse.CourseName,
                CourseUrl = imagePaths.FirstOrDefault() ?? "",
                CreatedAt = DateTime.Now,
                IsRead = false,
                NotificationType = NotificationType.Update
            };

            await _notify.AddNotification(notification);

            // Send notification to admins via SignalR
            await _hubContext.Clients.Group("Admins").SendAsync("ReceiveCourseNotification",
                new
                {
                    CourseId = existingCourse.CourseId,
                    CourseName = existingCourse.CourseName,
                    CourseUrl = notification.CourseUrl,
                    CreatedAt = existingCourse.UpdatedAt,
                    Action = "Update"
                });

            TempData["Success"] = "Update học mới thành công!";

            return RedirectToAction("Index");
        }



    }
}


public class DeleteImageRequest
{
    public string ImagePath { get; set; }
}