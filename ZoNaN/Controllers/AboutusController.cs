using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers
{
    public class AboutusController : Controller
    {
        private readonly ZonanDbContext _context;
        public AboutusController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> AboutUs()
        {
            AboutUsViewModel model = new AboutUsViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c=>c.IsAboutUs==true).FirstOrDefaultAsync(),
                AboutUs =await _context.AboutUs.FirstOrDefaultAsync(),
                Abouts = await _context.AboutUs.Skip(1).Take(3).ToListAsync()
            };
                return View(model);
        }
    }
}
