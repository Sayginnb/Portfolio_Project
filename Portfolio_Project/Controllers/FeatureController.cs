using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = featureManager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUptade(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
