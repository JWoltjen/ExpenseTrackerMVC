using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerMVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
