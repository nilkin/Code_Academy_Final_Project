using CryptoHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Areas.Manager.ViewModels;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.Filter;

namespace ZoNaN.Areas.Manager.Controllers
{
    [TypeFilter(typeof(AdminProfile))]
    [Area("Manager")]
    public class AdminController : Controller
    {
        private readonly ZonanDbContext _context;
        private User user => RouteData.Values["User"] as User;
        public AdminController(ZonanDbContext context)
        {
            _context = context;
        }
        // GET: AdminController 
        public ActionResult Index()
        {

            if (user == null)
            {
                return RedirectToAction("login", "admin", new { area = "manager" });
            }
            var profile = _context.Users.Find(user.Id);

            return View(profile);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

                if (user != null)
                {
                    if (Crypto.VerifyHashedPassword(user.Password, model.Password))
                    {
                        user.Token = Crypto.HashPassword(DateTime.Now.ToString());

                        _context.SaveChanges();

                        Response.Cookies.Append("token", user.Token, new CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(1),
                            HttpOnly = true
                        });
                        return RedirectToAction("index", "Admin", new { area = "manager" });

                    }
                }

                ModelState.AddModelError("Password", "Email or password is incorrect");
            }

            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (_context.Users.Any(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email", "This e-mail address is already registered");
            }

            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    Password = Crypto.HashPassword(model.Password),
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("login", "admin", new { area = "manager" });
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            var profile = _context.Users.Find(user.Id);
            profile.Token = null;
           await _context.SaveChangesAsync();
            return Redirect("/");
        }
    }
}
