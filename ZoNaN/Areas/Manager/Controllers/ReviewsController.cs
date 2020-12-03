using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ReviewsController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public ReviewsController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: ReviewsController
        public async Task<IActionResult> Index()
        {
            var corporxDbContext = _context.Reviews
                .Include(m => m.Product);
            return View(await corporxDbContext.ToListAsync());
        }

        // ReviewsController/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var image = _context.Reviews.Find(Id);

            if (image == null) return NotFound();

            _context.Reviews.Remove(image);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
