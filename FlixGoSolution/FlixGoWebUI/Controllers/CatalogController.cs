using FlixGoWebUI.Models.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Controllers
{
    public class CatalogController : Controller
    {
        readonly FlixGoDbContext db;
        readonly FlixGoDbContext _context;
        public CatalogController(FlixGoDbContext db, FlixGoDbContext _context)
        {
            this.db = db;
            this._context = _context;
        }
        public IActionResult Grid()
        {
            return View();
        }
        public IActionResult List()
        {
       

            return View();
            
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Tv()
        {
            return View();
        }
    }
}
