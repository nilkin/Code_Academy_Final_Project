using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Filter;
using ZoNaN.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ProductPhotosController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public ProductPhotosController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: ProductPhotosController
        public async Task<IActionResult> Index()
        {
            var corporxDbContext = _context.ProductPhotos
                .Include(m => m.Product);
            return View(await corporxDbContext.ToListAsync());
        }

        // GET: ProductPhotosController/Create
        [TypeFilter(typeof(AdminAuth))]
        public IActionResult Create()
        {
            ViewData["ProductId"] =
                new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: ProductPhotosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Create(ProductPhoto image)
        {
            if (image.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (image.Upload.ContentType != "image/jpeg"
                    && image.Upload.ContentType
                    != "image/png"
                    && image.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (image.Upload.Length > 2048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                image.Photo = _fileManager.Upload(image.Upload, "wwwroot/uploads");
                _context.Add(image);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] =
                new SelectList(_context.Products, "Id", "Name",
                image.ProductId);
            return View(image);
        }

        // GET: ProductPhotosController/Edit/5
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.ProductPhotos.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] =
                new SelectList(_context.Products, "Id", "Name",
                image.ProductId);
            return View(image);
        }

        // POST: ProductPhotosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Edit(int id, ProductPhoto image)
        {
            if (id != image.Id)
            {
                return NotFound();
            }
            if (image.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (image.Upload.ContentType != "image/jpeg"
                    && image.Upload.ContentType
                    != "image/png"
                    && image.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (image.Upload.Length > 2048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _fileManager.Delete(image.Photo);
                    image.Photo = _fileManager.Upload(image.Upload);
                    _context.Update(image);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagesExists(image.Id))
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
            ViewData["ProductId"] =
                new SelectList(_context.Products, "Id", "Name",
                image.ProductId);
            return View(image);
        }

        private bool ImagesExists(int id)
        {
            return _context.ProductPhotos.Any(e => e.Id == id);
        }

        // GET: ProductPhotosController/Delete/5
        [TypeFilter(typeof(AdminAuth))]
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var image = _context.ProductPhotos.Find(Id);

            if (image == null) return NotFound();

            _fileManager.Delete(image.Photo);

            _context.ProductPhotos.Remove(image);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
