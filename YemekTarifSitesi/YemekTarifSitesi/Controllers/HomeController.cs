using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YemekTarifSitesi.Data;
using YemekTarifSitesi.Models;

namespace YemekTarifSitesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var yemekList = _context.Yemek;
            return View(yemekList.ToList());
        }

        public IActionResult Tarifler()
        {
            var model = new YemekTarifModel();
            model.Yemek = _context.Yemek.ToList();
            model.YemekTur = _context.YemekTur.ToList();
            return View(model);
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

    }
}
