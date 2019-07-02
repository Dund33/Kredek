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
    public class DestroyersController : Controller
    {
        private readonly StarFleet _context;
        private readonly IDestroyerService _service;

        public DestroyersController(StarFleet context, IDestroyerService service)
        {
            _context = context;
            _service = service;
        }

        // GET: Destroyers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Destroyers.ToListAsync());
        }

        // GET: Destroyers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiser = _service.GetFullDestroyerDTO(id);

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

            var cruiser = _service.GetBasicDestroyerDTO(id);

            if (cruiser == null)
            {
                return NotFound();
            }

            return View(cruiser);
        }

        // GET: Destroyers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destroyers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Lasers,BeamTrackers,TWR,Isp,Thrust,Weight")] Destroyer destroyer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destroyer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destroyer);
        }

        // GET: Destroyers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destroyer = await _context.Destroyers.FindAsync(id);
            if (destroyer == null)
            {
                return NotFound();
            }
            return View(destroyer);
        }

        // POST: Destroyers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Lasers,BeamTrackers,TWR,Isp,Thrust,Weight")] Destroyer destroyer)
        {
            if (id != destroyer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destroyer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestroyerExists(destroyer.ID))
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
            return View(destroyer);
        }

        // GET: Destroyers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destroyer = await _context.Destroyers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (destroyer == null)
            {
                return NotFound();
            }

            return View(destroyer);
        }

        // POST: Destroyers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destroyer = await _context.Destroyers.FindAsync(id);
            _context.Destroyers.Remove(destroyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestroyerExists(int id)
        {
            return _context.Destroyers.Any(e => e.ID == id);
        }
    }
}
