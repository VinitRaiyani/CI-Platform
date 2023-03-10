using CI_PLATFORM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_PLATFORM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Forgot_Password()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Newpassword()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}