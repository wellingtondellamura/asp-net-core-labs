using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class CategoryController:Controller
    {

        private readonly BookStoreDBContext _context;

        public CategoryController(BookStoreDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        
        //GET
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
                _context.Add(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }            
            return View(category);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound();
            }            
            return View(category);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Update(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }            
            return View(category);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound();
            }            
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category category)
        {
            if (_context.Categories.Any(c => c.CategoryId ==  category.CategoryId))
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            } else {
                    return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}