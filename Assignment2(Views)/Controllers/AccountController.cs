using Microsoft.AspNetCore.Mvc;

namespace Assignment2_Views_.Controllers
{
	public class AccountController : Controller
	{

		public IActionResult Login()
		{
			return View();
		}

		public IActionResult SignUp() {
			return View();
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
