using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TextbookFinder.Data;
using TextbookFinder.Models;

namespace TextbookFinder.Controllers
{
    public class TextbooksController : Controller
    {
        private readonly TextbookFinderContext _context;

        public TextbooksController(TextbookFinderContext context)
        {
            _context = context;
        }

        // GET: Textbooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Textbooks.ToListAsync());
        }

        // GET: Textbooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbooks = await _context.Textbooks
                .FirstOrDefaultAsync(m => m.Textbook_id == id);
            if (textbooks == null)
            {
                return NotFound();
            }

            return View(textbooks);
        }

        // GET: Textbooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Textbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Textbook_id,Title,Edition,Isbn,published_date,publisher_id")] Textbooks textbooks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(textbooks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(textbooks);
        }

        // GET: Textbooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbooks = await _context.Textbooks.FindAsync(id);
            if (textbooks == null)
            {
                return NotFound();
            }
            return View(textbooks);
        }

        // POST: Textbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Textbook_id,Title,Edition,Isbn,published_date,publisher_id")] Textbooks textbooks)
        {
            if (id != textbooks.Textbook_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(textbooks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextbooksExists(textbooks.Textbook_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(textbooks);
        }

        // GET: Textbooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbooks = await _context.Textbooks
                .FirstOrDefaultAsync(m => m.Textbook_id == id);
            if (textbooks == null)
            {
                return NotFound();
            }

            return View(textbooks);
        }

        // POST: Textbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var textbooks = await _context.Textbooks.FindAsync(id);
            _context.Textbooks.Remove(textbooks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextbooksExists(int id)
        {
            return _context.Textbooks.Any(e => e.Textbook_id == id);
        }
    }
}
