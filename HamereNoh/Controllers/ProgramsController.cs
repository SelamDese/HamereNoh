using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HamereNoh.Data;
using HamereNoh.Models;
using Microsoft.AspNetCore.Identity;

namespace HamereNoh.Controllers
{
    public class ProgramsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public ProgramsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Programs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Programs.ToListAsync());
        }

        // GET: Programs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programT = await _context.Programs
                .FirstOrDefaultAsync(m => m.ProgramId == id);
            if (programT == null)
            {
                return NotFound();
            }

            return View(programT);
        }

        // GET: Programs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Programs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramId,ProgramName")] ProgramT programT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programT);
        }

        // GET: Programs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programT = await _context.Programs.FindAsync(id);
            if (programT == null)
            {
                return NotFound();
            }
            return View(programT);
        }

        // POST: Programs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProgramId,ProgramName")] ProgramT programT)
        {
            if (id != programT.ProgramId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramTExists(programT.ProgramId))
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
            return View(programT);
        }

        // GET: Programs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programT = await _context.Programs
                .FirstOrDefaultAsync(m => m.ProgramId == id);
            if (programT == null)
            {
                return NotFound();
            }

            return View(programT);
        }

        // POST: Programs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programT = await _context.Programs.FindAsync(id);
            _context.Programs.Remove(programT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramTExists(int id)
        {
            return _context.Programs.Any(e => e.ProgramId == id);
        }
    }
}
