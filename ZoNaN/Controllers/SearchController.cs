using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Models;

namespace ZoNaN.Controllers 
{
    public class SearchController : Controller
    {
        private readonly ZonanDbContext _context;
        public SearchController(ZonanDbContext context)
        {
            _context = context;
        }
        public IActionResult Search(string search)
        {
            Product model = _context.Products
                .Include(d => d.ProductPhotos)
                .Where(d => d.Name.ToLower()
                .Contains(search.ToLower())).FirstOrDefault();
            if (model==null)
            {
                return RedirectToAction("error", "error");
            }
            return RedirectToAction( "productSingle","Product", new { id = model.Id });
        }
    }
}
