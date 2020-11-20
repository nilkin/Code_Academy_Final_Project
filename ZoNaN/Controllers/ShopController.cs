using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.Models;
using ZoNaN.Services;
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

        //Cart
        public async Task<IActionResult> Cart()
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            CartViewModel model = new CartViewModel
            {       
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsCart == true).FirstOrDefaultAsync(),
                CartItems = cart,
                GrandTotal = cart.Sum(x=>x.Price * x.Quantity)
            };
            return View(model);
        }

        public async Task<IActionResult> Add(int Id)
        {
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c=>c.Id==Id);
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            BasketItem basketItem = cart.Where(x=>x.Id == Id).FirstOrDefault();
            if (basketItem==null)
            {
                cart.Add(new BasketItem(product));
            }
            else
            {
                basketItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Cart", cart);
            if (HttpContext.Request.Headers["X-Requested-With"] != "XMLHttpRequest")
                 return RedirectToAction("cart");
            return ViewComponent("NavCart");
            
        }
        public IActionResult Decrease(int Id)
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            BasketItem basketItem = cart.Where(x => x.Id == Id).FirstOrDefault();
            if (basketItem.Quantity > 1)
            {
               -- basketItem.Quantity;
            }
            else
            {
                cart.RemoveAll(x=>x.Id==Id);
            }
          
            if (cart.Count==0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            return RedirectToAction("cart");
        }

        public IActionResult Remove(int Id)
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            cart.RemoveAll(x => x.Id == Id);
            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> Wish()
        {
            WishViewModel model = new WishViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsWish == true).FirstOrDefaultAsync(),
                WishBaskets = await _context.Baskets.Where(c => c.isWish == true)
                .Include(c => c.Product).ThenInclude(c => c.ProductPhotos)
                .Include(c => c.Product).ThenInclude(c => c.Stock)
                .ToListAsync(),
            };
            return View(model);
        }
    }
}
