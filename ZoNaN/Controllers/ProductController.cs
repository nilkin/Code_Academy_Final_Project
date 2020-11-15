using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
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
            };
            return View(model);
        }
        public async Task<IActionResult> productSingle()
        {
            BlogSingleViewModel model = new BlogSingleViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsProductSingle == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> compare()
        {
            CompareViewModel model = new CompareViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsCompare == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }
}
