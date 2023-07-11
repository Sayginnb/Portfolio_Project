using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
