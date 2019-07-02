using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tftWEB.Models;

namespace tftWEB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Champions()
        {
            using (var context = new TFTContext())
            {
                var champs = await context.Champions.AsNoTracking().Include(p => p.Class).Include(p => p.Origin).ToListAsync();
                return View(champs);
            }
        }

        public async Task<IActionResult> Items()
        {
            using (var context = new TFTContext())
            {
                var items = await context.Items.AsNoTracking().ToListAsync();
                return View(items);
            }
        }

        public async Task<IActionResult> ItemRelations()
        {
            using (var context = new TFTContext())
            {
                var itemRelations = await context.ItemRelations.Include(p => p.NextItem).Include(p => p.PreviousItem1).Include(p => p.PreviousItem2).AsNoTracking().ToListAsync();
                return View(itemRelations);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
