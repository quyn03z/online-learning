using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations.Admin;
using OnlineLearning.Services.Interfaces.Admin;

namespace OnlineLearning.Areas.Admin.Controllers
{
    [Authorize(Roles = nameof(RoleType.ADMIN))]
    [Area("Admin")]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public async Task<IActionResult> Index()
        {
            //ViewBag.Notifications = await _notificationService.GetNotifications() ?? new List<Notification>();
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> MarkAllReaded()
        {
            try
            {
                await _notificationService.MarkAllRead();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> ClearAllNotifications()
        {
            try
            {
                await _notificationService.ClearAll();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
