using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.Miscellaneous;
using OnlineLearning.Models.Domains.UserCourseRelationship;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Controllers
{
    public class CheckoutController : Controller
    {
        private IMomoService _momoService;
        private ITransactionService _transactionService;
        private IUserService _userService;
        private ICourseEnrollmentService _courseEnrollmentService;
        private readonly IGoogleSheetsService _googleSheetsService; // Thêm service
        public CheckoutController(IMomoService momoService, ITransactionService transactionService, ICourseEnrollmentService courseEnrollmentService, IGoogleSheetsService googleSheetsService, IUserService userService)
        {
            _momoService = momoService;
            _courseEnrollmentService = courseEnrollmentService;
            _transactionService = transactionService;
            _googleSheetsService = googleSheetsService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> PaymentCallBack()
        {  
            var orderId = HttpContext.Session.GetString("OrderId");
            var userId = HttpContext.Session.GetString("userIdBuyCourse");
            var courseId = HttpContext.Session.GetString("CourseId");

            var response = await _momoService.PaymentExecuteAsync(HttpContext.Request.Query, long.Parse(courseId));
            var requestQuery = HttpContext.Request.Query;// get data from url
            if (int.TryParse(requestQuery.First(s => s.Key == "errorCode").Value, out int resultCode) && resultCode == 0) // Nếu thành công thì add vô database
            {
                //... code here
                // Lấy thông tin giao dịch từ MoMo
                var transaction = new TransactionHistory
                {
                    UserId = long.Parse(userId),
                    Amount = decimal.Parse(requestQuery["amount"]),
                    CourseId = long.Parse(courseId),
                    TransactionType = Enums.TransactionType.External,
                    PaymentMethod = Enums.PaymentMethod.Momo,
                    ExternalTransactionId = requestQuery["transId"],
                    Status = Enums.TransactionStatus.Completed,
                    Description = requestQuery["orderInfo"],
                    CreatedAt = DateTime.UtcNow,
                };

                bool transationStatus = await _transactionService.AddTransactionAsync(transaction);
                if (!transationStatus) {
                    TempData["ErrorMessage"] = "Không lưu transaction vô db được";
                    return View(response);
                }
                var courseEnrollment = new CourseEnrollment
                {
                    UserId = long.Parse(userId),
                    CourseId = long.Parse(courseId),
                    Status = Enums.EnrollmentStatus.Enrolled,
                };
                bool enrollment = await _courseEnrollmentService.AddCourseEnrollmmentAsync(courseEnrollment);
                if (!enrollment)
                {
                    TempData["ErrorMessage"]= "Không lưu enrollment vô db được";
                    return View(response);
                }

                //nếu thành công hết thì chia tiền cho mentor và admin
                //var creator = _userService.GetHashCode();


                // Tính toán doanh số và đẩy lên Google Sheets
                var now = DateTime.UtcNow;
                var dailyRevenue = await _transactionService.GetDailyRevenueAsync(now);
                var monthlyRevenue = await _transactionService.GetMonthlyRevenueAsync(now);
                var yearlyRevenue = await _transactionService.GetYearlyRevenueAsync(now);

                var revenueModel = new Models.DTOs.RevenueDto
                {
                    DailyRevenue = dailyRevenue,
                    MonthlyRevenue = monthlyRevenue,
                    YearlyRevenue = yearlyRevenue
                };

                await _googleSheetsService.UpdateRevenueAsync(revenueModel);

                TempData["ErrorMessage"] = "Giao dịch thành công";

            }
            else
            {
                TempData["ErrorMessage"] = "Đã hủy giao dịch";
                return RedirectToAction("DetailsCourse", "Course", new {Area = "", courseId = courseId});
            }
            return View(response);
        }


    }
}
