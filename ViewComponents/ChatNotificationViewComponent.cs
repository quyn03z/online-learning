using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineLearning.Services.Interfaces;
using System.Threading.Tasks;

namespace OnlineLearning.ViewComponents
{
    public class ChatNotificationViewComponent : ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChatNotificationViewComponent(IMessageService messageService, IHttpContextAccessor httpContextAccessor)
        {
            _messageService = messageService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                return View(0);
            }

            var userIdString = httpContext.Session.GetString("UserId");
            int unreadCount = 0;
            
            if (!string.IsNullOrEmpty(userIdString) && long.TryParse(userIdString, out long userId))
            {
                var chatPartners = await _messageService.GetChatPartnersAsync(userId);
                unreadCount = chatPartners.Sum(cp => cp.UnreadCount);
            }

            return View(unreadCount);
        }
    }
}
