using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
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

        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(ApplicationDbContext context, IStringLocalizer<HomeController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = _localizer.GetString("Message");
            var yemekList = _context.Yemek;
            return View(yemekList.ToList());
        }

        public IActionResult Tarifler()
        {
            var model = new YemekTarifModel();
            model.Yemek = _context.Yemek.ToList();
            model.Malzeme = _context.Malzeme.ToList();
            model.YemekTur = _context.YemekTur.ToList();
            model.YemekMalzeme = _context.YemekMalzeme.ToList();
            return View(model);
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

    }
}
