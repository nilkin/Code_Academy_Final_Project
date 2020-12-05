using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Filter;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ContactUsController : Controller
    {
        private readonly ZonanDbContext _context;
        public ContactUsController(ZonanDbContext context)
        {
            _context = context;
        }
        // GET: ContactUsController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contacts.ToListAsync());
        }

        // GET: ContactUsController/Delete/5 
        [TypeFilter(typeof(AdminAuth))]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null) return NotFound();

            _context.Contacts.Remove(contact);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}
