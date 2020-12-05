using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
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
        public async Task<IActionResult> BlogGrid(int page = 1, int pageSize = 3)
        {
            var items = _context.Blogs.AsNoTracking().OrderBy(x => x.Id);
            var pagingData = await PagingList.CreateAsync(items, pageSize, page);
            BlogGridViewModel model = new BlogGridViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsBlog == true).FirstOrDefaultAsync(),
                Blogs = pagingData
            };
            return View(model);
        }
        public async Task<IActionResult> BlogSingle(int Id)
        {
            Blog BlogSingle = await _context.Blogs
       .Include("Comments").FirstOrDefaultAsync(c => c.Id == Id);
            BlogSingleViewModel model = new BlogSingleViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsBlogSingle == true).FirstOrDefaultAsync(),
                SingleBlog = BlogSingle
            };
            return View(model);
        }
    }
}
