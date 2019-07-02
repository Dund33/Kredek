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
    public class DestroyerRepairsController : Controller
    {
        private readonly StarFleet _context;
        private readonly IRepairService _service;

        public DestroyerRepairsController(StarFleet context, IRepairService service)
        {
            _context = context;
            _service = service;
        }

        // GET: DestroyerRepairs
        public async Task<IActionResult> Index()
        {
            var starFleet = _context.DestroyerRepair.Include(d => d.Ship);
            return View(await starFleet.ToListAsync());
        }

        // GET: DestroyerRepairs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destroyerRepair = await _context.DestroyerRepair
                .Include(d => d.Ship)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (destroyerRepair == null)
            {
                return NotFound();
            }

            return View(destroyerRepair);
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

        // GET: DestroyerRepairs/Create
        public IActionResult Create()
        {
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID");
            return View();
        }

        // POST: DestroyerRepairs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,Date,ShipID")] DestroyerRepair destroyerRepair)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destroyerRepair);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID", destroyerRepair.ShipID);
            return View(destroyerRepair);
        }

        // GET: DestroyerRepairs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destroyerRepair = await _context.DestroyerRepair.FindAsync(id);
            if (destroyerRepair == null)
            {
                return NotFound();
            }
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID", destroyerRepair.ShipID);
            return View(destroyerRepair);
        }

        // POST: DestroyerRepairs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,Date,ShipID")] DestroyerRepair destroyerRepair)
        {
            if (id != destroyerRepair.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destroyerRepair);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestroyerRepairExists(destroyerRepair.ID))
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
            ViewData["ShipID"] = new SelectList(_context.Cruisers, "ID", "ID", destroyerRepair.ShipID);
            return View(destroyerRepair);
        }

        // GET: DestroyerRepairs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destroyerRepair = await _context.DestroyerRepair
                .Include(d => d.Ship)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (destroyerRepair == null)
            {
                return NotFound();
            }

            return View(destroyerRepair);
        }

        // POST: DestroyerRepairs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destroyerRepair = await _context.DestroyerRepair.FindAsync(id);
            _context.DestroyerRepair.Remove(destroyerRepair);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestroyerRepairExists(int id)
        {
            return _context.DestroyerRepair.Any(e => e.ID == id);
        }
    }
}
