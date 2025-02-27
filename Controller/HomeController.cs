using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expance_Tracker.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
