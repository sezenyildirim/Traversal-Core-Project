﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraverselCoreApplication.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destination.Count();
            ViewBag.v2 = c.Guide.Count();
            ViewBag.v3 = "285";
           
            return View();
        }
    }
}
