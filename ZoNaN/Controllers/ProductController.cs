using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.Models;
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
        public async Task<IActionResult> productGrid()
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
        public async Task<IActionResult> productSingle(int Id)
        {
            Product productSingle = await _context.Products
                .Include("ProductPhotos")
                .Include("Stock")
                .Include("Reviews").FirstOrDefaultAsync(c => c.Id == 3);
            Product productSingleCategory = await _context.Products.FindAsync(3);
            
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
        public async Task<IActionResult> compare()
        {

            CompareViewModel model = new CompareViewModel
            {

                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsCompare == true).FirstOrDefaultAsync(),
                CompareProducts = await _context.Baskets.Where(c => c.isCompare == true)
                .Include(c=>c.Products).ThenInclude(c=>c.ProductPhotos)
                .Include(c => c.Products).ThenInclude(c => c.Stock)
                .ToListAsync(),

            };
            return View(model);
        }
    }
}
