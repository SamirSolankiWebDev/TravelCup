using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelCup.Data;
using TravelCup.Models;

namespace TravelCup.Controllers
{
    public class TravelCupClassesController : Controller
    {
        private readonly MvcTravelCupContext _context;

        public TravelCupClassesController(MvcTravelCupContext context)
        {
            _context = context;
        }

        // GET: TravelCupClasses
        public async Task<IActionResult> Index(string searchString)
        {
            var cup = from m in _context.TravelCupClass
                         select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                cup = cup.Where(s => s.CupsTitle.Contains(searchString));
            }
            return View(await cup.ToListAsync());

        }

        // GET: TravelCupClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelCupClass = await _context.TravelCupClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelCupClass == null)
            {
                return NotFound();
            }

            return View(travelCupClass);
        }

        // GET: TravelCupClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelCupClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CupsTitle,ManufactureDate,Shape,Colour,Size,Price")] TravelCupClass travelCupClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelCupClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelCupClass);
        }

        // GET: TravelCupClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelCupClass = await _context.TravelCupClass.FindAsync(id);
            if (travelCupClass == null)
            {
                return NotFound();
            }
            return View(travelCupClass);
        }

        // POST: TravelCupClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CupsTitle,ManufactureDate,Shape,Colour,Size,Price")] TravelCupClass travelCupClass)
        {
            if (id != travelCupClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelCupClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelCupClassExists(travelCupClass.Id))
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
            return View(travelCupClass);
        }

        // GET: TravelCupClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelCupClass = await _context.TravelCupClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelCupClass == null)
            {
                return NotFound();
            }

            return View(travelCupClass);
        }

        // POST: TravelCupClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelCupClass = await _context.TravelCupClass.FindAsync(id);
            _context.TravelCupClass.Remove(travelCupClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelCupClassExists(int id)
        {
            return _context.TravelCupClass.Any(e => e.Id == id);
        }
    }
}
