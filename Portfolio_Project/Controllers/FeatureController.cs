using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
