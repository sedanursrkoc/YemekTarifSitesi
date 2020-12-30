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
    public class YemekMalzemeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YemekMalzemeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: YemekMalzeme
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.YemekMalzeme.Include(y => y.Malzeme).Include(y => y.Yemek);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: YemekMalzeme/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemekMalzeme = await _context.YemekMalzeme
                .Include(y => y.Malzeme)
                .Include(y => y.Yemek)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yemekMalzeme == null)
            {
                return NotFound();
            }

            return View(yemekMalzeme);
        }

        // GET: YemekMalzeme/Create
        public IActionResult Create()
        {
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Adi");
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "YemekAdi");
            return View();
        }

        // POST: YemekMalzeme/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,YemekId,MalzemeId")] YemekMalzeme yemekMalzeme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yemekMalzeme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id", yemekMalzeme.MalzemeId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", yemekMalzeme.YemekId);
            return View(yemekMalzeme);
        }

        // GET: YemekMalzeme/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemekMalzeme = await _context.YemekMalzeme.FindAsync(id);
            if (yemekMalzeme == null)
            {
                return NotFound();
            }
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id", yemekMalzeme.MalzemeId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", yemekMalzeme.YemekId);
            return View(yemekMalzeme);
        }

        // POST: YemekMalzeme/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,YemekId,MalzemeId")] YemekMalzeme yemekMalzeme)
        {
            if (id != yemekMalzeme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yemekMalzeme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YemekMalzemeExists(yemekMalzeme.Id))
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
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id", yemekMalzeme.MalzemeId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", yemekMalzeme.YemekId);
            return View(yemekMalzeme);
        }

        // GET: YemekMalzeme/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemekMalzeme = await _context.YemekMalzeme
                .Include(y => y.Malzeme)
                .Include(y => y.Yemek)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yemekMalzeme == null)
            {
                return NotFound();
            }

            return View(yemekMalzeme);
        }

        // POST: YemekMalzeme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yemekMalzeme = await _context.YemekMalzeme.FindAsync(id);
            _context.YemekMalzeme.Remove(yemekMalzeme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YemekMalzemeExists(int id)
        {
            return _context.YemekMalzeme.Any(e => e.Id == id);
        }
    }
}
