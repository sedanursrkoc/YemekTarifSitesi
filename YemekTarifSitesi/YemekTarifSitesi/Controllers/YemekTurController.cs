using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YemekTarifSitesi.Data;
using YemekTarifSitesi.Models;

namespace YemekTarifSitesi.Controllers
{
    public class YemekTurController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YemekTurController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: YemekTur
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.YemekTur.Include(y => y.Tur).Include(y => y.Yemek);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: YemekTur/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemekTur = await _context.YemekTur
                .Include(y => y.Tur)
                .Include(y => y.Yemek)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yemekTur == null)
            {
                return NotFound();
            }

            return View(yemekTur);
        }

        // GET: YemekTur/Create
        public IActionResult Create()
        {
            ViewData["TurId"] = new SelectList(_context.Tur, "Id", "Adi");
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "YemekAdi");
            return View();
        }

        // POST: YemekTur/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,YemekId,TurId")] YemekTur yemekTur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yemekTur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurId"] = new SelectList(_context.Tur, "Id", "Id", yemekTur.TurId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", yemekTur.YemekId);
            return View(yemekTur);
        }

        // GET: YemekTur/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemekTur = await _context.YemekTur.FindAsync(id);
            if (yemekTur == null)
            {
                return NotFound();
            }
            ViewData["TurId"] = new SelectList(_context.Tur, "Id", "Id", yemekTur.TurId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", yemekTur.YemekId);
            return View(yemekTur);
        }

        // POST: YemekTur/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,YemekId,TurId")] YemekTur yemekTur)
        {
            if (id != yemekTur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yemekTur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YemekTurExists(yemekTur.Id))
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
            ViewData["TurId"] = new SelectList(_context.Tur, "Id", "Id", yemekTur.TurId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", yemekTur.YemekId);
            return View(yemekTur);
        }

        // GET: YemekTur/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemekTur = await _context.YemekTur
                .Include(y => y.Tur)
                .Include(y => y.Yemek)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yemekTur == null)
            {
                return NotFound();
            }

            return View(yemekTur);
        }

        // POST: YemekTur/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yemekTur = await _context.YemekTur.FindAsync(id);
            _context.YemekTur.Remove(yemekTur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YemekTurExists(int id)
        {
            return _context.YemekTur.Any(e => e.Id == id);
        }
    }
}
