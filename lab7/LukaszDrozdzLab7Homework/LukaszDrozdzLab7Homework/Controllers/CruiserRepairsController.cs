using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LukaszDrozdzLab7Homework.Models;
using LukaszDrozdzLab7Homework.Services;

namespace LukaszDrozdzLab7Homework.Controllers
{
    public class CruiserRepairsController : Controller
    {
        private readonly StarFleet _context;
        private readonly IRepairService _service;

        public CruiserRepairsController(StarFleet context, IRepairService service)
        {
            _context = context;
            _service = service;
        }

        // GET: CruiserRepairs
        public async Task<IActionResult> Index()
        {
            var starFleet = _context.Repairs.Include(c => c.Ship);
            return View(await starFleet.ToListAsync());
        }

        // GET: CruiserRepairs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiserRepair = await _context.Repairs
                .Include(c => c.Ship)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cruiserRepair == null)
            {
                return NotFound();
            }

            return View(cruiserRepair);
        }

        /// <summary>
        /// Provide user with basic information using DTO
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Basic(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repair = _service.GetRepairDTO(id);

            if (repair == null)
            {
                return NotFound();
            }

            return View(repair);
        }

        // GET: CruiserRepairs/Create
        public IActionResult Create()
        {
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID");
            return View();
        }

        // POST: CruiserRepairs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,Date,ShipID")] CruiserRepair cruiserRepair)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cruiserRepair);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID", cruiserRepair.ShipID);
            return View(cruiserRepair);
        }

        // GET: CruiserRepairs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiserRepair = await _context.Repairs.FindAsync(id);
            if (cruiserRepair == null)
            {
                return NotFound();
            }
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID", cruiserRepair.ShipID);
            return View(cruiserRepair);
        }

        // POST: CruiserRepairs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,Date,ShipID")] CruiserRepair cruiserRepair)
        {
            if (id != cruiserRepair.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cruiserRepair);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CruiserRepairExists(cruiserRepair.ID))
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
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID", cruiserRepair.ShipID);
            return View(cruiserRepair);
        }

        // GET: CruiserRepairs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiserRepair = await _context.Repairs
                .Include(c => c.Ship)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cruiserRepair == null)
            {
                return NotFound();
            }

            return View(cruiserRepair);
        }

        // POST: CruiserRepairs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cruiserRepair = await _context.Repairs.FindAsync(id);
            _context.Repairs.Remove(cruiserRepair);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CruiserRepairExists(int id)
        {
            return _context.Repairs.Any(e => e.ID == id);
        }
    }
}
