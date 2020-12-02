using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class TestimonialsController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public TestimonialsController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: TestimonialsController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testimonials.ToListAsync());
        }

        // GET: TestimonialsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestimonialsController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Testimonial testimonial)
        {
            if (testimonial.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (testimonial.Upload.ContentType != "image/jpeg" && testimonial.Upload.ContentType != "image/png"
                    && testimonial.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (testimonial.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }


            if (ModelState.IsValid)
            {
                testimonial.Photo = _fileManager.Upload(testimonial.Upload, "wwwroot/uploads");
                _context.Add(testimonial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testimonial);
        }

        // GET: TestimonialsController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var testimonial = await _context.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        // POST: TestimonialsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Testimonial testimonial)
        {
            if (id != testimonial.Id)
            {
                return NotFound();
            }
            if (testimonial.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (testimonial.Upload.ContentType != "image/jpeg" && testimonial.Upload.ContentType != "image/png"
                 && testimonial.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (testimonial.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _fileManager.Delete(testimonial.Photo);
                    testimonial.Photo = _fileManager.Upload(testimonial.Upload);
                    _context.Update(testimonial).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestimonialsExists(testimonial.Id))
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
            return View(testimonial);
        }

        private bool TestimonialsExists(int id)
        {
            return _context.Testimonials.Any(e => e.Id == id);
        }

        [HttpPost]
        // GET: TestimonialsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);

            if (testimonial == null) return NotFound();

            _fileManager.Delete(testimonial.Photo);

            _context.Testimonials.Remove(testimonial);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
