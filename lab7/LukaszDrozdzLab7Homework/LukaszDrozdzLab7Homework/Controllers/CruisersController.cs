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
    public class CruisersController : Controller
    {
        private readonly StarFleet _context;
        private readonly ICruiserService _service;

        public CruisersController(StarFleet context, ICruiserService service)
        {
            _context = context;
            _service = service;
        }

        // GET: Cruisers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cruisers.ToListAsync());
        }

        // GET: Cruisers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiser = _service.GetFullCruiserDTO(id);

            if (cruiser == null)
            {
                return NotFound();
            }

            return View(cruiser);
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

            var cruiser = _service.GetBasicCruiserDTO(id);

            if (cruiser == null)
            {
                return NotFound();
            }

            return View(cruiser);
        }

        // GET: Cruisers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cruisers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Lasers,PlasmaGuns,HasStarDrive,TWR,Isp,Thrust,Weight")] Cruiser cruiser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cruiser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cruiser);
        }

        // GET: Cruisers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiser = await _context.Cruisers.FindAsync(id);
            if (cruiser == null)
            {
                return NotFound();
            }
            return View(cruiser);
        }

        // POST: Cruisers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Lasers,PlasmaGuns,HasStarDrive,TWR,Isp,Thrust,Weight")] Cruiser cruiser)
        {
            if (id != cruiser.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cruiser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CruiserExists(cruiser.ID))
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
            return View(cruiser);
        }

        // GET: Cruisers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiser = await _context.Cruisers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cruiser == null)
            {
                return NotFound();
            }

            return View(cruiser);
        }

        // POST: Cruisers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cruiser = await _context.Cruisers.FindAsync(id);
            _context.Cruisers.Remove(cruiser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CruiserExists(int id)
        {
            return _context.Cruisers.Any(e => e.ID == id);
        }
    }
}
