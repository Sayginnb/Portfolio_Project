using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class ContactSubplaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.TUptade(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
