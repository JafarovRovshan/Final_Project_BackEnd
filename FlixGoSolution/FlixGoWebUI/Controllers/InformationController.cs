using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
    }
}
