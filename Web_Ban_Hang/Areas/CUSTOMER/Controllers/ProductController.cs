using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web_Ban_Hang.Models;

namespace Web_Ban_Hang.Areas.CUSTOMER.Controllers
{
    [Area("CUSTOMER")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.DSSP = _context.Products.ToList();
            ViewBag.DSLOAI = _context.Categories.ToList();
            return View();
        }

        public IActionResult FilterByCategory(int categoryId)
        {
            var filteredProducts = _context.Products
                                           .Where(p => p.CategoryId == categoryId)
                                           .ToList();
            ViewBag.DSSP = filteredProducts;
            ViewBag.DSLOAI = _context.Categories.ToList();
            return View("Index"); // dùng lại View Index
        }
    }
}
