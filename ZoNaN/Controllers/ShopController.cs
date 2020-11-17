﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers
{
    public class ShopController : Controller
    {
        private readonly ZonanDbContext _context;
        public ShopController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> cart()
        {
            CartViewModel model = new CartViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsCart == true).FirstOrDefaultAsync(),
                CartBaskets = await _context.Baskets.Where(c => c.isCart == true)
                .Include(c => c.Products).ThenInclude(c => c.ProductPhotos)
                .Include(c => c.Products).ThenInclude(c => c.Stock)
                .ToListAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> wish()
        {
            WishViewModel model = new WishViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsWish == true).FirstOrDefaultAsync(),
                WishBaskets = await _context.Baskets.Where(c => c.isWish == true)
                .Include(c => c.Products).ThenInclude(c => c.ProductPhotos)
                .Include(c => c.Products).ThenInclude(c => c.Stock)
                .ToListAsync(),
            };
            return View(model);
        }
    }
}
