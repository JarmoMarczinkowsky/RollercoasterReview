﻿using System;
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
    public class ParksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Parks
        public async Task<IActionResult> Index()
        {
              return _context.Park != null ? 
                          View(await _context.Park.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Park'  is null.");
        }

        // GET: Parks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Park == null)
            {
                return NotFound();
            }

            var park = await _context.Park
                .FirstOrDefaultAsync(m => m.ParkId == id);
            if (park == null)
            {
                return NotFound();
            }

            return View(park);
        }

        // GET: Parks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParkId,Name,Country,City")] Park park)
        {
            if (ModelState.IsValid)
            {
                _context.Add(park);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(park);
        }

        // GET: Parks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Park == null)
            {
                return NotFound();
            }

            var park = await _context.Park.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }
            return View(park);
        }

        // POST: Parks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParkId,Name,Country,City")] Park park)
        {
            if (id != park.ParkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(park);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkExists(park.ParkId))
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
            return View(park);
        }

        // GET: Parks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Park == null)
            {
                return NotFound();
            }

            var park = await _context.Park
                .FirstOrDefaultAsync(m => m.ParkId == id);
            if (park == null)
            {
                return NotFound();
            }

            return View(park);
        }

        // POST: Parks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Park == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Park'  is null.");
            }
            var park = await _context.Park.FindAsync(id);
            if (park != null)
            {
                _context.Park.Remove(park);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkExists(int id)
        {
          return (_context.Park?.Any(e => e.ParkId == id)).GetValueOrDefault();
        }
    }
}
