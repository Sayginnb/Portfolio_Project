using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Portfolio_Project.Areas.Writer.ViewComponents
{
    public class Natification : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
