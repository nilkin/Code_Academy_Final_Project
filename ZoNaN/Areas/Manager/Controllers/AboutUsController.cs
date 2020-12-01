using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Filter;
using ZoNaN.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Admin.Controllers
{

    [Area("Manager")]
    public class AboutUsController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public AboutUsController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Manager/AboutUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutUs.ToListAsync());
        }

        // GET: Manager/AboutUs/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AboutUs aboutUs)
        {
            if (aboutUs.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (aboutUs.Upload.ContentType != "image/jpeg" && aboutUs.Upload.ContentType != "image/png" && aboutUs.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (aboutUs.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }


            if (ModelState.IsValid)
            {
                aboutUs.Photo = _fileManager.Upload(aboutUs.Upload, "wwwroot/uploads");
                _context.Add(aboutUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUs);
        }
        [TypeFilter(typeof(Auth))]
        // GET: Manager/AboutUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var aboutUs = await _context.AboutUs.FindAsync(id);
            if (aboutUs == null)
            {
                return NotFound();
            }
            return View(aboutUs);
        }

        // POST: Manager/AboutUs/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(Auth))]
        public async Task<IActionResult> Edit(int id,AboutUs aboutUs)
        {
            if (id != aboutUs.Id)
            {
                return NotFound();
            }
            if (aboutUs.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (aboutUs.Upload.ContentType != "image/jpeg" && aboutUs.Upload.ContentType != "image/png"
                 && aboutUs.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (aboutUs.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(aboutUs.Photo);
                    aboutUs.Photo = _fileManager.Upload(aboutUs.Upload);
                    _context.Update(aboutUs).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutUsExists(aboutUs.Id))
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
            return View(aboutUs);
        }
        // GET: Manager/AboutUs/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var aboutUs = await _context.AboutUs.FindAsync(id);

            if (aboutUs == null) return NotFound();

            _fileManager.Delete(aboutUs.Photo);

            _context.AboutUs.Remove(aboutUs);

            await  _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        private bool AboutUsExists(int id)
        {
            return _context.AboutUs.Any(e => e.Id == id);
        }

    }
}