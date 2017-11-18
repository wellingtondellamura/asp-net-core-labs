using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class BookController:Controller
    {

        private readonly BookStoreDBContext _context;

        public BookController(BookStoreDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Books
                .Include(b => b.Category)
                .AsNoTracking()
                .ToList());
        }
        
        //GET
        public IActionResult Create()
        {
            PopulateCategoriesDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }            
            PopulateCategoriesDropDownList(book.CategoryId);
            return View(book);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var book = _context.Books
                .Include(b => b.Category)
                .AsNoTracking()
                .SingleOrDefault(b => b.BookId == id);

            if (book == null)
            {
                return NotFound();
            }            
            PopulateCategoriesDropDownList(book.CategoryId);
            return View(book);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }            
            PopulateCategoriesDropDownList(book.CategoryId);
            return View(book);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book =_context.Books
                .Include(b => b.Category)
                .AsNoTracking()
                .SingleOrDefault(b => b.BookId == id);

            if (book == null)
            {
                return NotFound();
            }          
            PopulateCategoriesDropDownList(book.CategoryId);  
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Book book)
        {
            if (_context.Books.Any(b => b.BookId ==  book.BookId))
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            } else {
                    return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }



        public IActionResult AddImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var book = _context.Books
                .Include(b => b.Category)
                .AsNoTracking()
                .SingleOrDefault(b => b.BookId == id);

            if (book == null)
            {
                return NotFound();
            }            
            PopulateCategoriesDropDownList(book.CategoryId);
            return View(book);
        }

        private void PopulateCategoriesDropDownList(object selectedCategory = null)
        {
            var categoriesQuery = from c in _context.Categories
                                   orderby c.Name
                                   select c;
            ViewBag.CategoryId = new SelectList(categoriesQuery.AsNoTracking(), "CategoryId", "Name", selectedCategory);
        }

    }
}