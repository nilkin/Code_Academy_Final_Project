using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers
{
    public class BlogController : Controller
    {
        private readonly ZonanDbContext _context;
        public BlogController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> blogGrid()
        {
            BlogGridViewModel model = new BlogGridViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsBlog == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> blogSingle()
        {
            BlogGridViewModel model = new BlogGridViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsBlogSingle == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }
}
