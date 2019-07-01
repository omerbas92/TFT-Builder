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
            using (var context = new TFTContext())
            {
                var champs = await context.Champions.AsNoTracking().ToListAsync();
                var items = await context.Items.AsNoTracking().ToListAsync();
                var itemrelations = await context.ItemRelations.Include(p => p.NextItem).Include(p => p.PreviousItem1).Include(p => p.PreviousItem2).AsNoTracking().ToListAsync();
                return View(items);
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
