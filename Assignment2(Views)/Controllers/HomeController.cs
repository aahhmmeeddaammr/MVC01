using Microsoft.AspNetCore.Mvc;

namespace Assignment2_Views_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AboutUs() {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
