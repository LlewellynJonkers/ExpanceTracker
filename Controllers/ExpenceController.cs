using Expance_Tracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace Expance_Tracker.Controllers
{
    public class ExpenceController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IRepositoryWrapper _wrapper;
        ExpenceController(IRepositoryWrapper wrapper) : base()
        {
            _wrapper = wrapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
