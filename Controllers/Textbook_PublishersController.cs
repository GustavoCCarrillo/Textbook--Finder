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
    public class Textbook_PublishersController : Controller
    {
        private readonly TextbookFinderContext _context;

        public Textbook_PublishersController(TextbookFinderContext context)
        {
            _context = context;
        }

        // GET: Textbook_Publishers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Textbook_Publishers.ToListAsync());
        }

        // GET: Textbook_Publishers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbook_Publishers = await _context.Textbook_Publishers
                .FirstOrDefaultAsync(m => m.Publisher_id == id);
            if (textbook_Publishers == null)
            {
                return NotFound();
            }

            return View(textbook_Publishers);
        }

        // GET: Textbook_Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Textbook_Publishers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Publisher_id,Publisher_name,Publisher_website")] Textbook_Publishers textbook_Publishers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(textbook_Publishers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(textbook_Publishers);
        }

        // GET: Textbook_Publishers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbook_Publishers = await _context.Textbook_Publishers.FindAsync(id);
            if (textbook_Publishers == null)
            {
                return NotFound();
            }
            return View(textbook_Publishers);
        }

        // POST: Textbook_Publishers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Publisher_id,Publisher_name,Publisher_website")] Textbook_Publishers textbook_Publishers)
        {
            if (id != textbook_Publishers.Publisher_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(textbook_Publishers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Textbook_PublishersExists(textbook_Publishers.Publisher_id))
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
            return View(textbook_Publishers);
        }

        // GET: Textbook_Publishers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textbook_Publishers = await _context.Textbook_Publishers
                .FirstOrDefaultAsync(m => m.Publisher_id == id);
            if (textbook_Publishers == null)
            {
                return NotFound();
            }

            return View(textbook_Publishers);
        }

        // POST: Textbook_Publishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var textbook_Publishers = await _context.Textbook_Publishers.FindAsync(id);
            _context.Textbook_Publishers.Remove(textbook_Publishers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Textbook_PublishersExists(int id)
        {
            return _context.Textbook_Publishers.Any(e => e.Publisher_id == id);
        }
    }
}
