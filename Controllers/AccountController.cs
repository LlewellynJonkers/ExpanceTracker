using Expance_Tracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expance_Tracker.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
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
            return View(new LoginModel());
        }
    }
}
