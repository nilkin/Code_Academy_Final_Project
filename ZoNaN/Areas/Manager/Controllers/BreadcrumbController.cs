using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class BreadcrumbController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public BreadcrumbController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: BreadcrumbController
        public async Task<ActionResult> Index()
        {
            return View(await _context.Breadcrumbs.ToListAsync());
        }

        // GET: BreadcrumbController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BreadcrumbController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Breadcrumb breadcrumb)
        {
            if (breadcrumb.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (breadcrumb.Upload.ContentType != "image/jpeg" && breadcrumb.Upload.ContentType != "image/png" && breadcrumb.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (breadcrumb.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                breadcrumb.Photo = _fileManager.Upload(breadcrumb.Upload, "wwwroot/uploads");
                _context.Add(breadcrumb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(breadcrumb);
        }

        // GET: BreadcrumbController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var breadcrumb = await _context.Breadcrumbs.FindAsync(id);
            if (breadcrumb == null)
            {
                return NotFound();
            }
            return View(breadcrumb);
        }

        // POST: BreadcrumbController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Breadcrumb breadcrumb)
        {
            if (id != breadcrumb.Id)
            {
                return NotFound();
            }
            if (breadcrumb.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (breadcrumb.Upload.ContentType != "image/jpeg" && breadcrumb.Upload.ContentType != "image/png"
                 && breadcrumb.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (breadcrumb.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(breadcrumb.Photo);
                    breadcrumb.Photo = _fileManager.Upload(breadcrumb.Upload);
                    _context.Update(breadcrumb).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BreadcrumbExists(breadcrumb.Id))
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
            return View(breadcrumb);
        }

        private bool BreadcrumbExists(int Id)
        {
            return _context.Breadcrumbs.Any(e => e.Id == Id);
        }
        public ActionResult Delete()
        {
            return View();
        }
            // POST: BreadcrumbController/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var breadcrumb = _context.Breadcrumbs.Find(Id);

            if (breadcrumb == null) return NotFound();

            _fileManager.Delete(breadcrumb.Photo);

            _context.Breadcrumbs.Remove(breadcrumb);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
