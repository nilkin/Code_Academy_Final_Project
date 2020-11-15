using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.ViewModels;

namespace ZoNaN.Controllers
{
    public class AccountController : Controller
    {
        private readonly ZonanDbContext _context;
        public AccountController(ZonanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> profile()
        {

            ProfileViewModel model = new ProfileViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsProfile == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> login()
        {

            LoginViewModel model = new LoginViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsLogin == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> register()
        {

            RegisterViewModel model = new RegisterViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsRegister == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> chekout()
        {

            ChekoutViewModel model = new ChekoutViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsChekout == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }
}
