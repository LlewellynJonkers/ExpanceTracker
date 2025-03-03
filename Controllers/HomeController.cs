using Expance_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expance_Tracker.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger _logger;
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            return View(login);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
