using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
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
            };
            return View(model);
        }
        public async Task<IActionResult> Add(int id)
        {
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c=>c.Id== id);
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            BasketItem basketItem = cart.Where(x => x.Id == id).FirstOrDefault();
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
                return RedirectToAction("Cart");
            return ViewComponent("IconBadgeComponent");
        }
        //public async Task<IActionResult> Increase(int id)
        //{
        //    var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == id);
        //    List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
        //    BasketItem basketItem = cart.Where(x => x.Id == id).FirstOrDefault();
        //    basketItem.Quantity += 1;
        //    HttpContext.Session.SetJson("Cart", cart);
        //    if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
        //        return RedirectToAction("Cart");
        //    return RedirectToAction("Cart", cart);
        //}
        public async Task<IActionResult> AddToSideNavCart(int id)
        {
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == id);
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            BasketItem basketItem = cart.Where(x => x.Id == id).FirstOrDefault();
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
                return RedirectToAction("Cart");
            return ViewComponent("CartNavComponent");
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
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Cart");
            return ViewComponent("CartNavComponent");
        }  
        public IActionResult RemoveBadgeAjax(int Id)  
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
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Cart");
            return ViewComponent("IconBadgeComponent");
        }   
        public IActionResult RemoveAjax(int Id)
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>(); 
            cart.RemoveAll(x => x.Id == Id);
            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else 
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Cart");
            return RedirectToAction("Cart");
        }
        public IActionResult RemoveIconBadgeCount(int Id)
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart") ?? new List<BasketItem>();
            cart.RemoveAll(x => x.Id == Id);
            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("Cart");
            return ViewComponent("IconBadgeComponent");
        }
        //Wislist
        public async Task<IActionResult> Wish()
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish") ?? new List<BasketItem>();
            WishViewModel model = new WishViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsWish == true).FirstOrDefaultAsync(),
                WishItems = wish,
            };
            return View(model);
        }
        public async Task<IActionResult> AddToWish(int Id)
        {
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == Id);
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish") ?? new List<BasketItem>();
            BasketItem wishItem = wish.Where(x => x.Id == Id).FirstOrDefault();
            if (wishItem == null)
            {
                wish.Add(new BasketItem(product));
            }
            else
            {
                wishItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Wish", wish);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("wish");
            return ViewComponent("WishIconBadgeComponent");
        }
        public async Task<IActionResult> AddToWishNavWish(int Id)
        {
            var product = await _context.Products.Include("Stock").Include("ProductPhotos").FirstOrDefaultAsync(c => c.Id == Id);
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish") ?? new List<BasketItem>();
            BasketItem wishItem = wish.Where(x => x.Id == Id).FirstOrDefault();
            if (wishItem == null)
            {
                wish.Add(new BasketItem(product));
            }
            else
            {
                wishItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Wish", wish);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return RedirectToAction("wish");
            return ViewComponent("WishNavComponent");
        }
        public IActionResult RemoveFromWish(int Id)
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            wish.RemoveAll(x => x.Id == Id);
            if (wish.Count == 0)
            {
                HttpContext.Session.Remove("Wish");
            }
            else  
            {
                HttpContext.Session.SetJson("Wish", wish);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect(Request.Headers["Referer"].ToString());
            return ViewComponent("WishNavComponent");
        }
        public IActionResult RemoveFromWishAjax(int Id)
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            wish.RemoveAll(x => x.Id == Id);
            if (wish.Count == 0)
            {
                HttpContext.Session.Remove("Wish");
            }
            else
            {
                HttpContext.Session.SetJson("Wish", wish);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect(Request.Headers["Referer"].ToString());
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult RemoveFromWishIconBadgeCount(int Id)
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            wish.RemoveAll(x => x.Id == Id);
            if (wish.Count == 0)
            {
                HttpContext.Session.Remove("Wish");
            }
            else
            {
                HttpContext.Session.SetJson("Wish", wish);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect(Request.Headers["Referer"].ToString());
            return ViewComponent("WishIconBadgeComponent");
        }
        public async Task<IActionResult> AddFromWishToCart(int Id)
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            wish.RemoveAll(x => x.Id == Id);
            if (wish.Count == 0)
            {
                HttpContext.Session.Remove("Wish");
            }
            else
            {
                HttpContext.Session.SetJson("Wish", wish);
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
            if (HttpContext.Request.Headers["X-Requested-With"] != "XMLHttpRequest")
            {
                return RedirectToAction("cart");
            }

            return ViewComponent("WishIconBadgeComponent");

        }
        public async Task<IActionResult> AddFromWishToCartAjax(int Id)
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            wish.RemoveAll(x => x.Id == Id);
            if (wish.Count == 0)
            {
                HttpContext.Session.Remove("Wish");
            }
            else
            {
                HttpContext.Session.SetJson("Wish", wish);
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
            if (HttpContext.Request.Headers["X-Requested-With"] != "XMLHttpRequest")
            {
                return RedirectToAction("cart");
            }

            return RedirectToAction("Wish");

        }
    }
}
