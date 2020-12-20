using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lunch.Data;
using Lunch.Models;
using Lunch.Interfaces;
using Lunch.ViewModels;

namespace Lunch.Controllers
{
    public class PlacesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAllPlaces _allPlaces;
        private readonly IAllMenus _allMenus;
        private readonly IAllKitchens _allKitchens;
        private readonly IAllLinks _allLinkss;
        public PlacesController(IAllPlaces iAllPlaces, IAllMenus iAllMenus, IAllKitchens iAllKitchens, IAllLinks iAllLinkss, ApplicationDbContext context)
        {
            _allPlaces = iAllPlaces;
            _allMenus = iAllMenus;
            _allKitchens = iAllKitchens;
            _allLinkss = iAllLinkss;
            _context = context;
        }
        // GET: Places
        [Route("Places/Index")]
        [Route("Places/Index/{kitchen}")]
        public ViewResult Index(string kitchen)
        {
            string _kitchen = kitchen;
            IEnumerable<Place> places = null;
            IEnumerable<Link> links = null;

            string currKitchen = "";
            if (string.IsNullOrEmpty(kitchen))
            {
                places = _allPlaces.GetAllPlaces().OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("russian", kitchen, StringComparison.OrdinalIgnoreCase))
                {
                    places = _allPlaces.Places.Where(i => i.Kitchen.kitchen_name.Equals("Русская")).OrderBy(i => i.id);


                    currKitchen = "Русская";

                }
                else if (string.Equals("kazakh", kitchen, StringComparison.OrdinalIgnoreCase))
                {
                    places = _allPlaces.Places.Where(i => i.Kitchen.kitchen_name.Equals("Казахская")).OrderBy(i => i.id);
                    currKitchen = "Казахская";

                }
                else if (string.Equals("eastern", kitchen, StringComparison.OrdinalIgnoreCase))
                {
                    places = _allPlaces.Places.Where(i => i.Kitchen.kitchen_name.Equals("Восточная")).OrderBy(i => i.id);
                    currKitchen = "Восточная";
                }
                links = _allLinkss.Links.Where(i => i.place.id.Equals(2)).OrderBy(i => i.id);

            }

            var placeObj = new PlaceListViewModel
            {
                allLinks = links,
                allPlaces = places,
                currKitchen = currKitchen
            };



            return View(placeObj);
        }

        // GET: Places/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
/*
            var place2 = await _context.Places
                .Include(p => p.Kitchen)
                .Include(p=>p.Links)
                .FirstOrDefaultAsync(m => m.id == id);*/

            var place = new PlacesData();
            place.Places = await _context.Places
                  .Include(i => i.Links)
                  .Include(i => i.Menus)
                  .AsNoTracking()
                  .OrderBy(i => i.place_name)
                  .ToListAsync();
                  

            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        // GET: Places/Create
        public IActionResult Create()
        {
            ViewData["kitchenId"] = new SelectList(_context.Kitchens, "id", "id");
            return View();
        }

        // POST: Places/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,place_name,short_desc,desc,av_price,img,address,phone,isFavourite,kitchenId")] Place place)
        {
            if (ModelState.IsValid)
            {
                _context.Add(place);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["kitchenId"] = new SelectList(_context.Kitchens, "id", "id", place.kitchenId);
            return View(place);
        }

        // GET: Places/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Places.FindAsync(id);
            if (place == null)
            {
                return NotFound();
            }
            ViewData["kitchenId"] = new SelectList(_context.Kitchens, "id", "id", place.kitchenId);
            return View(place);
        }

        // POST: Places/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,place_name,short_desc,desc,av_price,img,address,phone,isFavourite,kitchenId")] Place place)
        {
            if (id != place.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(place);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaceExists(place.id))
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
            ViewData["kitchenId"] = new SelectList(_context.Kitchens, "id", "id", place.kitchenId);
            return View(place);
        }

        // GET: Places/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Places
                .Include(p => p.Kitchen)
                .FirstOrDefaultAsync(m => m.id == id);
            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        // POST: Places/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var place = await _context.Places.FindAsync(id);
            _context.Places.Remove(place);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaceExists(int id)
        {
            return _context.Places.Any(e => e.id == id);
        }
    }
}
