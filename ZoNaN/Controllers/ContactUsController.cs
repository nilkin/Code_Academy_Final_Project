using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly ZonanDbContext _context;
        public ContactUsController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> contact()
        {
            ContactViewModel model = new ContactViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsContact == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }
}
