﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
