using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Project.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
