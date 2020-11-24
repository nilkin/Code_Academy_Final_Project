using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.Models;
using ZoNaN.Services;
using ZoNaN.ViewModels; 

namespace ZoNaN.Controllers
{
    public class ProductController : Controller
    {
        private readonly ZonanDbContext _context;
        public ProductController(ZonanDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> ProductGrid()
        {
            ProductGridViewModel model = new ProductGridViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsProduct == true).FirstOrDefaultAsync(),
                ProductsGrid = await _context.Products
                .Include(c => c.ProductPhotos)
                .Include(c => c.SubCategory)
                .Include(i => i.Stock)
                .ToListAsync()
            };
            return View(model);
        }
        public async Task<IActionResult> ProductSingle(int Id)
        {
            Product productSingle = await _context.Products
                .Include("ProductPhotos")
                .Include("Stock")
                .Include("Reviews").FirstOrDefaultAsync(c => c.Id == Id);
            Product productSingleCategory = await _context.Products.FindAsync(Id);
            
            var rand = new Random();
            if (productSingle == null)
            {

                return NotFound();
            }
            ProductSingleViewModel model = new ProductSingleViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsProductSingle == true).FirstOrDefaultAsync(),
                ProductSingle = productSingle,
                LikeProducts = await _context.Products.OrderBy(emp => Guid.NewGuid()).Take(6).Include(i => i.ProductPhotos).Include(i => i.Stock).ToListAsync(),
                SameCategoryProducts = await _context.Products.OrderBy(emp => Guid.NewGuid()).Where(c=>c.SubCategoryId == productSingleCategory.SubCategoryId).Take(6).Include(i => i.ProductPhotos).Include(i => i.Stock).ToListAsync()
            };
            return View(model);
        } 
        public async Task<IActionResult> Compare()
        {
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare") ?? new List<CompareItem>();
            CompareViewModel model = new CompareViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsCompare == true).FirstOrDefaultAsync(),
                CompareItems = Compare
            };
            return View(model);
        }
        public async Task<IActionResult> AddToCompare(int Id)
        {
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == Id);
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare") ?? new List<CompareItem>();
            CompareItem CompareItem = Compare.Where(x => x.Id == Id).FirstOrDefault();
            Compare.Add(new CompareItem(product));
            HttpContext.Session.SetJson("Compare", Compare);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("compare");
            return ViewComponent("CompareIconBagdeComponent");
        }
        public IActionResult RemoveFromCompare(int Id)
        {
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare");
            Compare.RemoveAll(x => x.Id == Id);
            if (Compare.Count == 0)
            {
                HttpContext.Session.Remove("Compare");
            }
            else
            {
                HttpContext.Session.SetJson("Compare", Compare);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Compare");
            return ViewComponent("CompareIconBagdeComponent"); 
        }
        public IActionResult RemoveFromCompareAjax(int Id)
        {
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare");
            Compare.RemoveAll(x => x.Id == Id);
            if (Compare.Count == 0)
            {
                HttpContext.Session.Remove("Compare");
            }
            else 
            {
                HttpContext.Session.SetJson("Compare", Compare);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Compare");
            return RedirectToAction("Compare");
        }
        public async Task<IActionResult> AddFromCompareToCart(int Id)
        {
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare");
            Compare.RemoveAll(x => x.Id == Id);
            if (Compare.Count == 0)
            {
                HttpContext.Session.Remove("Compare");
            }
            else
            {
                HttpContext.Session.SetJson("Compare", Compare);
            }
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == Id);
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            BasketItem basketItem = cart.Where(x => x.Id == Id).FirstOrDefault();
            if (basketItem == null)
            {
                cart.Add(new BasketItem(product));
            }
            else
            {
                basketItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Cart", cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Compare");
            return ViewComponent("CompareIconBagdeComponent");
        }
        public async Task<IActionResult> AddFromCompareToCartAjax(int Id)
        {
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare");
            Compare.RemoveAll(x => x.Id == Id);
            if (Compare.Count == 0)
            {
                HttpContext.Session.Remove("Compare");
            }
            else
            {
                HttpContext.Session.SetJson("Compare", Compare);
            }
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == Id);
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            BasketItem basketItem = cart.Where(x => x.Id == Id).FirstOrDefault();
            if (basketItem == null)
            {
                cart.Add(new BasketItem(product));
            }
            else
            {
                basketItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Cart", cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Compare");
            return RedirectToAction("Compare");
        }
    }
}
