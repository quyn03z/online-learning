using Microsoft.AspNetCore.SignalR;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Services.Interfaces.Admin;
using System.Security.Claims;

namespace OnlineLearning.Hubs
{
    public class CourseNotificationHub : Hub
    {
        private readonly INotificationService _notificationService;
        public CourseNotificationHub(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public override async Task OnConnectedAsync()
        {
            // Kiểm tra nếu user có role "ADMIN" trong Claims
            if (Context.User.Claims.Any(c => c.Type == ClaimTypes.Role && c.Value == "ADMIN"))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, "Admins");
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Claims.Any(c => c.Type == ClaimTypes.Role && c.Value == "ADMIN"))
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, "Admins");
            }
            await base.OnDisconnectedAsync(exception);
        }


    }
}
