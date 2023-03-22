using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RollercoasterReview.Data;
using RollercoasterReview.Models;

namespace RollercoasterReview.Controllers
{
    public class RollercoastersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RollercoastersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Rollercoasters
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Rollercoaster.Include(r => r.Park);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Rollercoasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Rollercoaster == null)
            {
                return NotFound();
            }

            var rollercoaster = await _context.Rollercoaster
                .Include(r => r.Park)
                .FirstOrDefaultAsync(m => m.RollercoasterId == id);
            if (rollercoaster == null)
            {
                return NotFound();
            }

            return View(rollercoaster);
        }

        // GET: Rollercoasters/Create
        public IActionResult Create()
        {
            ViewData["Parks"] = new SelectList(_context.Park, "ParkId", "Name");
            return View();
        }

        // POST: Rollercoasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RollercoasterId,Name,BackgroundInfo,Year,Image,ParkId")] Rollercoaster rollercoaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rollercoaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Parks"] = new SelectList(_context.Park, "ParkId", "Name", rollercoaster.ParkId);
            return View(rollercoaster);
        }

        // GET: Rollercoasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Rollercoaster == null)
            {
                return NotFound();
            }

            var rollercoaster = await _context.Rollercoaster.FindAsync(id);
            if (rollercoaster == null)
            {
                return NotFound();
            }
            ViewData["Parks"] = new SelectList(_context.Park, "ParkId", "Name", rollercoaster.ParkId);
            return View(rollercoaster);
        }

        // POST: Rollercoasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RollercoasterId,Name,BackgroundInfo,Year,Image,ParkId")] Rollercoaster rollercoaster)
        {
            if (id != rollercoaster.RollercoasterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rollercoaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RollercoasterExists(rollercoaster.RollercoasterId))
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
            ViewData["Parks"] = new SelectList(_context.Park, "ParkId", "Name", rollercoaster.ParkId);
            return View(rollercoaster);
        }

        // GET: Rollercoasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Rollercoaster == null)
            {
                return NotFound();
            }

            var rollercoaster = await _context.Rollercoaster
                .Include(r => r.Park)
                .FirstOrDefaultAsync(m => m.RollercoasterId == id);
            if (rollercoaster == null)
            {
                return NotFound();
            }

            return View(rollercoaster);
        }

        // POST: Rollercoasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Rollercoaster == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Rollercoaster'  is null.");
            }
            var rollercoaster = await _context.Rollercoaster.FindAsync(id);
            if (rollercoaster != null)
            {
                _context.Rollercoaster.Remove(rollercoaster);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RollercoasterExists(int id)
        {
          return (_context.Rollercoaster?.Any(e => e.RollercoasterId == id)).GetValueOrDefault();
        }
    }
}
