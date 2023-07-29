using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents.Dashboard
{
    public class Last5Project : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
