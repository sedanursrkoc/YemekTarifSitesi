using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YemekTarifSitesi.Data;
using YemekTarifSitesi.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace YemekTarifSitesi.Controllers
{
    [Authorize]
    public class YemekController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public YemekController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Yemek
        public async Task<IActionResult> Index()
        {
            return View(await _context.Yemek.ToListAsync());
        }

        // GET: Yemek/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemek = await _context.Yemek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yemek == null)
            {
                return NotFound();
            }

            return View(yemek);
        }

        // GET: Yemek/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Yemek/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,YemekAdi,Malzemeler,Tarif,Puan,Fotograf")] Yemek yemek)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images/yemek/");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                yemek.Fotograf = @"/images/yemek/" + fileName + extension;

                _context.Add(yemek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(yemek);
        }

        // GET: Yemek/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemek = await _context.Yemek.FindAsync(id);
            if (yemek == null)
            {
                return NotFound();
            }
            return View(yemek);
        }

        // POST: Yemek/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,YemekAdi,Malzemeler,Tarif,Puan,Fotograf")] Yemek yemek)
        {
            if (id != yemek.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yemek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YemekExists(yemek.Id))
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
            return View(yemek);
        }

        // GET: Yemek/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yemek = await _context.Yemek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yemek == null)
            {
                return NotFound();
            }

            return View(yemek);
        }

        // POST: Yemek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yemek = await _context.Yemek.FindAsync(id);
            _context.Yemek.Remove(yemek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YemekExists(int id)
        {
            return _context.Yemek.Any(e => e.Id == id);
        }
    }
}
