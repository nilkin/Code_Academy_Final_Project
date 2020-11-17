using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Models;
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
                Blogs = await _context.Blogs.ToListAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> blogSingle(int Id)
        {
            Blog BlogSingle = await _context.Blogs
       .Include("Comments").FirstOrDefaultAsync(c => c.Id == 1);
            BlogSingleViewModel model = new BlogSingleViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsBlogSingle == true).FirstOrDefaultAsync(),
                SingleBlog = BlogSingle
            };
            return View(model);
        }
    }
}
