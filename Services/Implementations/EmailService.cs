﻿using OnlineLearning.Services.Interfaces;
using System.Net.Mail;
using System.Net;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography;
using System.Text;
using OnlineLearning.Utils;

namespace OnlineLearning.Services.Implementations
{
	public class EmailService : IEmailService
	{
		private readonly IConfiguration _config;
		private readonly IUserService _userService;

        public EmailService(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }

        public async Task SendNewPasswordEmailAsync(string toEmail)
        {
            var smtpSettings = _config.GetSection("Smtp");
            string host = smtpSettings["Host"];
            int port = int.Parse(smtpSettings["Port"]);
            bool enableSsl = bool.Parse(smtpSettings["EnableSSL"]);
            string username = smtpSettings["Username"];
            string password = smtpSettings["Password"];

			string newPassword = GenerateRandomPassword();

            var user = await _userService.GetUserByEmailAsync(toEmail);
			user.Password = PasswordUtils.HashPassword(newPassword); ;

			await _userService.UpdateUserAsync(user);

            // Gửi email chứa mật khẩu mới
            using (var smtpClient = new SmtpClient(host, port))
            {
                smtpClient.Credentials = new NetworkCredential(username, password);
                smtpClient.EnableSsl = enableSsl;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(username),
                    Subject = "Mật khẩu mới của bạn",
                    Body = $"Mật khẩu mới của bạn là: <strong>{newPassword}</strong>",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toEmail);

                await smtpClient.SendMailAsync(mailMessage);
            }

        }

        private string GenerateRandomPassword(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%^&*";
            StringBuilder result = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] byteBuffer = new byte[length];
                rng.GetBytes(byteBuffer);
                foreach (byte b in byteBuffer)
                {
                    result.Append(chars[b % chars.Length]);
                }
            }
            return result.ToString();
        }




        public async Task SendOtpEmailAsync(string toEmail, string otp)
		{
			var smtpSettings = _config.GetSection("Smtp");
			string host = smtpSettings["Host"];
			int port = int.Parse(smtpSettings["Port"]);
			bool enableSsl = bool.Parse(smtpSettings["EnableSSL"]);
			string username = smtpSettings["Username"];
			string password = smtpSettings["Password"];

			using (var client = new SmtpClient(host, port))
			{
				client.EnableSsl = enableSsl;
				client.Credentials = new NetworkCredential(username, password);

				var mailMessage = new MailMessage
				{
					From = new MailAddress(username),
					Subject = "Mã OTP Online-Learning Xác Nhận Của Bạn Là",
                    Body = $"Mã OTP của bạn là: <b>{otp}</b>. Mã OTP có hiệu lực trong <b>5 phút</b>.",
                    IsBodyHtml = true
				};
				mailMessage.To.Add(toEmail);

				await client.SendMailAsync(mailMessage);
			}
		}

        public async Task SendResponseReviewCourse(string toEmail, string courseName, bool isApproved, string reason = null)
        {
            var smtpSettings = _config.GetSection("Smtp");
            string host = smtpSettings["Host"];
            int port = int.Parse(smtpSettings["Port"]);
            bool enableSsl = bool.Parse(smtpSettings["EnableSSL"]);
            string username = smtpSettings["Username"];
            string password = smtpSettings["Password"];

            using (var client = new SmtpClient(host, port))
            {
                client.EnableSsl = enableSsl;
                client.Credentials = new NetworkCredential(username, password);

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(username),
                    Subject = isApproved ? $"Your course '{courseName}' has been approved" : $"Your course '{courseName}' has been rejected",
                    Body = isApproved
                        ? $"Dear user,<br/><br/>We are pleased to inform you that your course <b>{courseName}</b> has been approved. It is now available for users to access.<br/><br/>Thank you for your contribution!<br/>Best regards,<br/>The Online Learning Team"
                        : $"Dear user,<br/><br/>We regret to inform you that your course <b>{courseName}</b> has been rejected.<br/>" +
                          (string.IsNullOrEmpty(reason) ? "Please review our guidelines and resubmit." : $"Reason: <b>{reason}</b><br/>Please revise and resubmit.") +
                          "<br/><br/>Best regards,<br/>The Online Learning Team",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toEmail);

                await client.SendMailAsync(mailMessage);
            }
        }
    }
}
