﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
