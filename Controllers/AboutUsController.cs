using Microsoft.AspNetCore.Mvc;

namespace OnlineLearning.Controllers
{
	public class AboutUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
