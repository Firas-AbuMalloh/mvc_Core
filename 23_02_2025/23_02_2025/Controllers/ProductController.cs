using _23_02_2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23_02_2025.Controllers
{
    public class ProductController : Controller
    {

        private readonly MyDbContext _context;

        public ProductController(MyDbContext obj)
        {
            _context = obj;
        }
        public IActionResult Index()
        {

            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult Details(int Id)
        {
            var product = _context.Products.Find(Id);

            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {

            var obj = _context.Products.Find(Id);

            _context.Products.Remove(obj);
            _context.SaveChanges();

            return View("Index");
        }

        public IActionResult Edit(int Id)
        {
            var obj = _context.Products.Find(Id);
            
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();

            return RedirectToAction("Index","Product");
        }

    }
}
