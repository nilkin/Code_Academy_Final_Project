using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class SettingsController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public SettingsController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: SettingsController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Settings.ToListAsync());
        }

        // GET: SettingsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SettingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Setting set)
        {
            if (set.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (set.Upload.ContentType != "image/jpeg" &&
                    set.Upload.ContentType != "image/png" &&
                    set.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (set.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                set.Logo = _fileManager.Upload(set.Upload, "wwwroot/uploads");
                _context.Add(set);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(set);
        }


        // GET: SettingsController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var set = await _context.Settings.FindAsync(id);
            if (set == null)
            {
                return NotFound();
            }
            return View(set);
        }

        // POST: SettingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Setting set)
        {
            if (id != set.Id)
            {
                return NotFound();
            }
            if (set.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (set.Upload.ContentType != "image/jpeg" 
                    && set.Upload.ContentType != "image/png"
                 && set.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (set.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(set.Logo);
                    set.Logo = _fileManager.Upload(set.Upload);
                    _context.Update(set).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SetsExists(set.Id))
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
            return View(set);
        }

        private bool SetsExists(int ıd)
        {
            return _context.Settings.Any(e => e.Id == ıd);
        }

        // GET: SettingsController/Delete/5
        public async Task<IActionResult> Delete(int Id)
        {
            var set = await _context.Settings.FindAsync(Id);

            if (set == null) return NotFound();

            _fileManager.Delete(set.Logo);

            _context.Settings.Remove(set);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
