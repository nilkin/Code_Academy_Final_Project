using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class OrdersController : Controller
    {
        private readonly ZonanDbContext _context;
        public OrdersController(ZonanDbContext context)
        {
            _context = context;
        }
        // GET: OrdersController
        public async Task<IActionResult> Index()
        {
            var zonanDbContext = _context.Orders.Include(m => m.Chekout);
            return View(await zonanDbContext.ToListAsync());
        }

        // GET: OrdersController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["ChekoutId"] = new SelectList(_context.Chekouts, "Id", "Name", order.ChekoutId);
            return View(order);
        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersExists(order.Id))
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
            ViewData["ChekoutId"] = new SelectList(_context.Chekouts, "Id", "Name", order.ChekoutId);
            return View(order);
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }

        // GET: OrdersController/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var order = _context.Orders.Find(Id);

            if (order == null) return NotFound();

            _context.Orders.Remove(order);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
