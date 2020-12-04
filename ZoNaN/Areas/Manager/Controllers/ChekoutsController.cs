using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZoNaN.Data;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ChekoutsController : Controller
    {
        private readonly ZonanDbContext _context;
        public ChekoutsController(ZonanDbContext context)
        {
            _context = context;
        }
        // GET: ChekoutsController
        public async Task<IActionResult> Index()
        {
            var zonanDbContext = _context.Chekouts.Include(m => m.Customer);
            return View(await zonanDbContext.ToListAsync());
        }
    }
}
