using Microsoft.AspNetCore.Mvc;

namespace Task4.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
