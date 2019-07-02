using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LukaszDrozdzLab7.Models;
using LukaszDrozdzLab7.Services;

namespace LukaszDrozdzLab7.Controllers
{
    public class JumpersController : Controller
    {
        private readonly SkiJumpingContest _context;
        private readonly IJumperService _jumperService;

        public JumpersController(SkiJumpingContest context, IJumperService jumperService)
        {
            _jumperService = jumperService;
            _context = context;
        }

        // GET: Jumpers
        public async Task<IActionResult> Index()
        {
            var skiJumpingContest = _context.Jumpers.Include(j => j.Country);
            return View(await skiJumpingContest.ToListAsync());
        }

        public async Task<IActionResult> GetStatisticJumper(int id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var statisticJumper = _jumperService.GetStatisticJumper(id);
            return View(statisticJumper);
        }

        // GET: Jumpers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jumper = await _context.Jumpers
                .Include(j => j.Country)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jumper == null)
            {
                return NotFound();
            }

            return View(jumper);
        }

        // GET: Jumpers/Create
        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(_context.Countries, "ID", "Name");
            return View();
        }

        // POST: Jumpers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Birthday,Height,Weight,PersonalBest,CountryID")] Jumper jumper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jumper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "ID", "ID", jumper.CountryID);
            return View(jumper);
        }

        // GET: Jumpers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jumper = await _context.Jumpers.FindAsync(id);
            if (jumper == null)
            {
                return NotFound();
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "ID", "ID", jumper.CountryID);
            return View(jumper);
        }

        // POST: Jumpers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Birthday,Height,Weight,PersonalBest,CountryID")] Jumper jumper)
        {
            if (id != jumper.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jumper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JumperExists(jumper.ID))
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
            ViewData["CountryID"] = new SelectList(_context.Countries, "ID", "ID", jumper.CountryID);
            return View(jumper);
        }

        // GET: Jumpers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jumper = await _context.Jumpers
                .Include(j => j.Country)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jumper == null)
            {
                return NotFound();
            }

            return View(jumper);
        }

        // POST: Jumpers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jumper = await _context.Jumpers.FindAsync(id);
            _context.Jumpers.Remove(jumper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JumperExists(int id)
        {
            return _context.Jumpers.Any(e => e.ID == id);
        }
    }
}
