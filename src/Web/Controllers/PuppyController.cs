using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PuppyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greeting()
        {
            return Content("Hello!");
        }
        public IActionResult JSON()
        {
            return Json(new
            {
                name = "Rocky",
                since = "1951"
            });
        }
        

        public IActionResult HTML()
        {
            return Content("<!DOCTYPE html><html><body>Hello World</body></html>", "text/html");
        }

    }
}