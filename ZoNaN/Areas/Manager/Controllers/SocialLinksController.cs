using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class SocialLinksController : Controller
    {
        private readonly ZonanDbContext _context;
        public SocialLinksController(ZonanDbContext context)
        {
            _context = context;
        }
        // GET: SocialLinksController
        public async Task<IActionResult> Index()
        {
            return View(await _context.SocialLinks.ToListAsync());
        }

        // GET: SocialLinksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialLinksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SocialLink link)
        {
            if (ModelState.IsValid)
            {
                _context.Add(link);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(link);
        }

        // GET: SocialLinksController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var link = await _context.SocialLinks.FindAsync(id);
            if (link == null)
            {
                return NotFound();
            }
            return View(link);
        }

        // POST: SocialLinksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, SocialLink link)
        {
            if (id != link.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(link);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialExists(link.Id))
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
            return View(link);

        }

        private bool SocialExists(int id)
        {
            return _context.SocialLinks.Any(e => e.Id == id);
        }

        // GET: SocialLinksController/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            var link = await _context.SocialLinks.FindAsync(id);
            if (link != null)
            {
                _context.SocialLinks.Remove(link);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
