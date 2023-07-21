using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
