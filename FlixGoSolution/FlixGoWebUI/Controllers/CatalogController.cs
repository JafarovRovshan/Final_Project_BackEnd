using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Grid()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Movie()
        {
            return View();
        }
        public IActionResult Tv()
        {
            return View();
        }
    }
}
