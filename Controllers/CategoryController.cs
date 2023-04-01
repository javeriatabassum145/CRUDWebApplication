using CRUDWebApplication.Data;
using CRUDWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWebApplication.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDBContext _context;

        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories;
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
