using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
