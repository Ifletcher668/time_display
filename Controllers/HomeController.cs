using System;
using Microsoft.AspNetCore.Mvc;

namespace time_display.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now; 
            ViewBag.TimeDate = CurrentTime;
            // ViewBag.Name = "Tim"; 
            return View("index"); 
        }
    }
}