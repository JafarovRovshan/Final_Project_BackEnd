using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Pricing()
        {
            return View();
        }
    }
}
