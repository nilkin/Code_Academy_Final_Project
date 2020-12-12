using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly ZonanDbContext _context;
        public ContactUsController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Contact()
        {
            ContactViewModel model = new ContactViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsContact == true).FirstOrDefaultAsync(),
                ContactWithUs = await _context.Settings.FirstOrDefaultAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Message(ContactUs contact)
        {

            if (ModelState.IsValid)
            {
                ContactUs message = new ContactUs
                {
                    Fullname = contact.Fullname,
                    Subject = contact.Subject,
                    Email = contact.Email,
                    Message = contact.Message
                };
                await _context.Contacts.AddAsync(message);
                await _context.SaveChangesAsync();

                return Ok(new
                {
                    message = "Your message has been sent"
                });
            }

            return BadRequest(new
            {
                message = "Some of inputs is empty, Please enter information correctly"
            });
        }
    }
}
