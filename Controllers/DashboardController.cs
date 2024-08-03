using Microsoft.AspNetCore.Mvc;

namespace Expensify.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
