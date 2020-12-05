using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Filter;
using ZoNaN.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class BannerController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public BannerController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: BannerController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Banners.ToListAsync());
        }

        // GET: BannerController/Create
        [TypeFilter(typeof(AdminAuth))]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BannerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Create(Banner banner)
        {
            if (banner.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (banner.Upload.ContentType != "image/jpeg" && banner.Upload.ContentType != "image/png" && banner.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (banner.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                banner.Photo = _fileManager.Upload(banner.Upload, "wwwroot/uploads");
                _context.Add(banner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banner);
        }
        [TypeFilter(typeof(AdminAuth))]
        // GET: BannerController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var banner = await _context.Banners.FindAsync(id);
            if (banner == null)
            {
                return NotFound();
            }
            return View(banner);
        }

        // POST: BannerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Edit(int id, Banner banner)
        {
            if (id != banner.Id)
            {
                return NotFound();
            }
            if (banner.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (banner.Upload.ContentType != "image/jpeg" && banner.Upload.ContentType != "image/png"
                 && banner.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (banner.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(banner.Photo);
                    banner.Photo = _fileManager.Upload(banner.Upload);
                    _context.Update(banner).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannerExists(banner.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(banner);
        }

        // GET: BannerController/Delete/5 
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Delete(int id)
        {
            var banner = await _context.Banners.FindAsync(id);

            if (banner == null) return NotFound();

            _fileManager.Delete(banner.Photo);

            _context.Banners.Remove(banner);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }    

        private bool BannerExists(int id)
        {
            return _context.AboutUs.Any(e => e.Id == id);
        }
    }
}
