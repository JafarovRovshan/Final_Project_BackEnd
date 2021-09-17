using FlixGoWebUI.Models.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FlixGoWebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly FlixGoDbContext db;
        public HomeController(FlixGoDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var categories = db.Categories.ToList();


            return View(categories);



        }

        public IActionResult Index2()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }
       
    }

}
