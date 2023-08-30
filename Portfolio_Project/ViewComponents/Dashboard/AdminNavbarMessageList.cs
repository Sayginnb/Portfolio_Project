using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
