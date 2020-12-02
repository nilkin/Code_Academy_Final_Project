using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class SubscriberController : Controller
    {
        private readonly ZonanDbContext _context;
        public SubscriberController(ZonanDbContext context)
        {
            _context = context;
        }
        // GET: SubscriberController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subscribers.ToListAsync());
        }

        // GET: SubscriberController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriber = await _context.Subscribers.FindAsync(id);
            if (subscriber == null)
            {
                return NotFound();
            }
            return View(subscriber);
        }

        // POST: SubscriberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Subscriber subscriber)
        {
            if (id != subscriber.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscriber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriberExists(subscriber.Id))
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
            return View(subscriber);

        }
        private bool SubscriberExists(int id)
        {
            return _context.Subscribers.Any(e => e.Id == id);
        }

        // GET: SubscriberController/Delete/5 
        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            var subs = await _context.Subscribers.FindAsync(id);
            if (subs != null)
            {
                _context.Subscribers.Remove(subs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
