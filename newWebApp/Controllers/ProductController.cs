using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace newWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            ViewData["Message"] ="Soap";
            //var product = new Product{Name ="Soap"};
            return View();
        }
    }
}
