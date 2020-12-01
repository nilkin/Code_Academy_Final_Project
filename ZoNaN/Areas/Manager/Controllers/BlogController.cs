using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Models;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class BlogController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public BlogController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: BlogController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.ToListAsync());
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (blog.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (blog.Upload.ContentType != "image/jpeg" && blog.Upload.ContentType != "image/png" && blog.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (blog.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                blog.Photo = _fileManager.Upload(blog.Upload, "wwwroot/uploads");
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: BlogController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }
            if (blog.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (blog.Upload.ContentType != "image/jpeg" && blog.Upload.ContentType != "image/png"
                 && blog.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (blog.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(blog.Photo);
                    blog.Photo = _fileManager.Upload(blog.Upload);
                    _context.Update(blog).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogsExists(blog.Id))
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
            return View(blog);
        }

        // GET: BlogController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null) return NotFound();

            _fileManager.Delete(blog.Photo);

            _context.Blogs.Remove(blog);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        private bool BlogsExists(int ıd)
        {
            return _context.Blogs.Any(e => e.Id == ıd);
        }

    }
}
