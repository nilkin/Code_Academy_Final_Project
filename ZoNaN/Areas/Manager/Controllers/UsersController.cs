using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.Filter;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [TypeFilter(typeof(AdminAuth))]
    [Area("Manager")]
        public class UsersController : Controller
        {
            private readonly ZonanDbContext _context;
            private readonly IFileManager _fileManager;
        public UsersController(ZonanDbContext context, IFileManager fileManager)
            {
                _context = context;
                _fileManager = fileManager;
            }

            // GET: Manager/Users
            public async Task<IActionResult> Index()
            {
                return View(await _context.Users.ToListAsync());
            }

        // GET: Manager/Users/Create
        public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User use)
            {
                if (use.Upload == null)
                {
                    ModelState.AddModelError("Upload", "Photo is required");
                }
                else
                {
                    if (use.Upload.ContentType != "image/jpeg" && use.Upload.ContentType != "image/png"
                    && use.Upload.ContentType != "image/gif")
                    {
                        ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                    }

                    if (use.Upload.Length > 1048576)
                    {
                        ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                    }
                }


                if (ModelState.IsValid)
                {
                use.Photo = _fileManager.Upload(use.Upload, "wwwroot/uploads");
                    _context.Add(use);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(use);
            }

            // GET: Manager/Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var use = await _context.Users.FindAsync(id);
                if (use == null)
                {
                    return NotFound();
                }
                return View(use);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(User user)
        {
            if (user.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (user.Upload.ContentType != "image/jpeg" && user.Upload.ContentType != "image/png"
                 && user.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (user.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var dbuser = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
                    if (user.Photo == null)
                    {
                        user.Photo = _fileManager.Upload(user.Upload);
                        _context.Update(user).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    _fileManager.Delete(dbuser.Photo);
                    dbuser.Photo = _fileManager.Upload(user.Upload);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        // GET: Manager/Users/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var use = await _context.Users.FindAsync(id);

            if (use == null) return NotFound();

            _fileManager.Delete(use.Photo);

            _context.Users.Remove(use);

            await _context.SaveChangesAsync();

            return RedirectToAction("/");

        }
    }
}
