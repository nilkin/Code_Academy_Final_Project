using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.Models;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers 
{
    public class HomeController : Controller
    {
        private readonly ZonanDbContext _context;
        public HomeController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                MainBanners = await _context.Banners.Where(c => c.IsMain).ToListAsync(),
                PromoBanners = await _context.Banners.Where(c => c.IsPromo).ToListAsync(),
                Categories = await _context.Categories.Take(3).ToListAsync(),
                BestSelProducts = await _context.Products.Where(c => c.IsBestSel).Include(i => i.ProductPhotos).Include(i => i.Stock).ToListAsync(),
                FeaturedProducts = await _context.Products.Where(c => c.IsFeatured).Include(i => i.ProductPhotos).Include(i => i.Stock).ToListAsync(),
                Testimonials = await _context.Testimonials.Take(6).ToListAsync(),
                NewProducts = await _context.Products.Where(c => c.IsNew).Include(i => i.ProductPhotos).Include(i => i.Stock).ToListAsync(),
                DiscountBanner = await _context.Banners.OrderByDescending(s => s.Id).FirstOrDefaultAsync(),
                NewBlogs = await _context.Blogs.Where(c => c.IsNew).ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
            return BadRequest(new
            {
                message = "Please enter your email address correctly"
            });
            }

            if (_context.Subscribers.Any(c=>c.Email==email))
            {
                return NotFound(new
                {
                    message = "You are already subscribed to our newsletter"
                });
            }

            Subscriber subscriber = new Subscriber
            {
                Email = email
            };
            await _context.Subscribers.AddAsync(subscriber);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Your subscription is registered"
            });
        }
    }
}
