using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lunch.Data;
using Lunch.Models;

namespace Lunch.Controllers
{
    public class KitchensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KitchensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kitchens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kitchens.ToListAsync());
        }

        // GET: Kitchens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitchen = await _context.Kitchens
                .FirstOrDefaultAsync(m => m.id == id);
            if (kitchen == null)
            {
                return NotFound();
            }

            return View(kitchen);
        }

        // GET: Kitchens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kitchens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,kitchen_name")] Kitchen kitchen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kitchen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kitchen);
        }

        // GET: Kitchens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitchen = await _context.Kitchens.FindAsync(id);
            if (kitchen == null)
            {
                return NotFound();
            }
            return View(kitchen);
        }

        // POST: Kitchens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,kitchen_name")] Kitchen kitchen)
        {
            if (id != kitchen.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitchen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KitchenExists(kitchen.id))
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
            return View(kitchen);
        }

        // GET: Kitchens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitchen = await _context.Kitchens
                .FirstOrDefaultAsync(m => m.id == id);
            if (kitchen == null)
            {
                return NotFound();
            }

            return View(kitchen);
        }

        // POST: Kitchens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kitchen = await _context.Kitchens.FindAsync(id);
            _context.Kitchens.Remove(kitchen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KitchenExists(int id)
        {
            return _context.Kitchens.Any(e => e.id == id);
        }
    }
}
