using Microsoft.AspNetCore.Mvc;
using simple_crud.Data;
using System.Linq;
using simple_crud.Models;

namespace simple_crud.Controllers
{
    public class GenreController:Controller
    {

        private readonly MoviesDBContext _context;

        public GenreController(MoviesDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Genres.ToList());
        }
        
        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Description")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genre);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }            
            return View(genre);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _context.Genres.SingleOrDefault(g => g.GenreId == id);

            if (genre == null)
            {
                return NotFound();
            }            
            return View(genre);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Update(genre);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }            
            return View(genre);
        }

        // GET: Departments/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _context.Genres.SingleOrDefault(g => g.GenreId == id);

            if (genre == null)
            {
                return NotFound();
            }            
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Genre genre)
        {
            if (_context.Genres.Any(g => g.GenreId == genre.GenreId))
            {
                _context.Genres.Remove(genre);
                _context.SaveChanges();
            } else {
                    return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}