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
    public class SubCategoriesController : Controller
    {
        private readonly ZonanDbContext _context;
        public SubCategoriesController(ZonanDbContext context)
        {
            _context = context;
        }

        // GET: SubCategoriesController
        public async Task<IActionResult> Index()
        {
            var corporxDbContext = _context.SubCategories
                .Include(m => m.Category);
            return View(await corporxDbContext.ToListAsync());
        }

        // GET: SubCategoriesController/Create
        [TypeFilter(typeof(AdminAuth))]
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: SubCategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Create( SubCategory sub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", sub.CategoryId);
            return View(sub);
        }
        // GET: SubCategoriesController/Edit/5
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sub = await _context.SubCategories.FindAsync(id);
            if (sub == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", sub.CategoryId);
            return View(sub);
        }

        // POST: SubCategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Edit(int id, SubCategory sub)
        {
            if (id != sub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCategoryExists(sub.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", sub.CategoryId);
            return View(sub);
        }

        private bool SubCategoryExists(int id)
        {
            return _context.SubCategories.Any(e => e.Id == id);
        }

        // POST: SubCategoriesController/Delete/5
        [HttpPost]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<ActionResult> Delete(int id)
        {
            var sub = await _context.SubCategories.FindAsync(id);
            if (sub != null)
            {
                _context.SubCategories.Remove(sub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
