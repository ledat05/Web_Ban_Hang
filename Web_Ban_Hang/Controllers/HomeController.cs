using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_Ban_Hang.Models;

namespace Web_Ban_Hang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _db;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db= db;
        }

        public IActionResult Index(int page =1)
        {
            var pageSize = 3 ;
            var products = _db.Products.ToList();
            return View(products.Skip((page - 1)*pageSize).Take(pageSize).ToList());
        }
        public IActionResult LoadMore(int page = 1)
        {
            var pageSize = 3;
            var products = _db.Products.ToList();
            return PartialView("ProductPartial", products.Skip((page - 1) * pageSize).Take(pageSize).ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Information(int id)
        {
            var product = _db.Products.FirstOrDefault(p => p.MaSP == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult AddToCart (int id)
        {
            var product = _db.Products.FirstOrDefault(p => p.MaSP == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
