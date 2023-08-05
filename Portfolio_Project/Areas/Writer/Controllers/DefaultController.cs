using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
