namespace OnlineLearning.Services.Interfaces
{
	public interface IEmailService
	{
		Task SendOtpEmailAsync(string toEmail, string otp);
		Task SendResponseReviewCourse(string toEmail, string courseName, bool isApproved, string reason = null);

		Task SendNewPasswordEmailAsync(string toEmail);
	}
}
