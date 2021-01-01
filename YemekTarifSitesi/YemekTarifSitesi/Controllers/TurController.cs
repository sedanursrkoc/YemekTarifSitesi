using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YemekTarifSitesi.Data;
using YemekTarifSitesi.Models;

namespace YemekTarifSitesi.Controllers
{
    [Authorize]
    public class TurController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TurController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tur
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tur.ToListAsync());
        }

        // GET: Tur/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tur = await _context.Tur
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tur == null)
            {
                return NotFound();
            }

            return View(tur);
        }

        // GET: Tur/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tur/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Adi")] Tur tur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tur);
        }

        // GET: Tur/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tur = await _context.Tur.FindAsync(id);
            if (tur == null)
            {
                return NotFound();
            }
            return View(tur);
        }

        // POST: Tur/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Adi")] Tur tur)
        {
            if (id != tur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurExists(tur.Id))
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
            return View(tur);
        }

        // GET: Tur/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tur = await _context.Tur
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tur == null)
            {
                return NotFound();
            }

            return View(tur);
        }

        // POST: Tur/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tur = await _context.Tur.FindAsync(id);
            _context.Tur.Remove(tur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurExists(int id)
        {
            return _context.Tur.Any(e => e.Id == id);
        }
    }
}
