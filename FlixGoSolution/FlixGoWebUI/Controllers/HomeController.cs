using FlixGoWebUI.Models.DataContext;
using FlixGoWebUI.Models.ViewModels;
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
            FlixGoDbContext db = new FlixGoDbContext();
            HomeViewModel vm = new HomeViewModel();

            vm.Categories = db.Categories
                //.Where(c => c.DeletedByUserId == null)
                .ToList();

            vm.Products = db.Products
                //.Where(p => p.DeletedByUserId == null)
                //.Include(p => p.ImagePath)
                .Include(p => p.Genre)
                .ToList();


            return View(vm);



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
