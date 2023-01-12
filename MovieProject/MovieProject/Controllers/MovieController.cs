using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
