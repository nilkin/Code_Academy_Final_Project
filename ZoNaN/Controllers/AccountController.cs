using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.Models;
using ZoNaN.ViewModels;
using Microsoft.AspNetCore.Http;

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
        [HttpPost]
        public async Task<IActionResult> login(CustomerLoginViewModel customer)
        {

                Customer user = await _context.Customers.FirstOrDefaultAsync(u => u.Email == customer.Email);

                if (user != null)
                {
                    if (Crypto.VerifyHashedPassword(user.Password, customer.Password))
                    {
                        user.Token = Crypto.HashPassword(DateTime.Now.ToString());

                        _context.SaveChanges();

                        Response.Cookies.Append("token", user.Token, new CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(1),
                            HttpOnly = true
                        });
                    return Ok(new
                    {
                        message = "Welcome" +"  "+ user.Gender +" "+ user.Name
                    });

                    }
                }
                  return NotFound(new
                        {
                            message = "This member is not found"
                        });
            //ModelState.AddModelError("Password", "Email or password is incorrect");


            //return View(customer);
            //if (customer == null)
            //{
            //    return BadRequest(new
            //    {
            //        message = "Some of inputs is empty, Please enter information correctly"
            //    });
            //} 
            //Customer user = await _context.Customers.FirstOrDefaultAsync(u => u.Email == customer.Email);
            //if (!_context.Customers.Any(u => u.Email == customer.Email || Crypto.VerifyHashedPassword(user.Password, customer.Password)))
            //{
            //    return NotFound(new
            //    {
            //        message = "This member is not found"
            //    });
            //}

            //Customer profile = new Customer
            //{
            //    Email = customer.Email,
            //    Token = Crypto.HashPassword(customer.Token),
            //};
            //_context.Customers.Add(profile);
            //_context.SaveChanges();
            //return Ok(new
            //{
            //    message = "Welcome"+ user.Gender + user.Name
            //});
        }
        public async Task<IActionResult> register()
        {

            RegisterViewModel model = new RegisterViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsRegister == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        [HttpPost]  
        public IActionResult register(CustomerRegisterViewModel customer)
        {
            if (customer==null)
            {
                return BadRequest(new
                {
                    message = "Some of inputs is empty, Please enter information correctly"
                });
            }
            if (_context.Customers.Any(u => u.Email == customer.Email))
            {
                return NotFound(new
                {
                    message = "This member is already registered"
                });
            }

                Customer user = new Customer
                {
                    Gender = customer.Gender,
                    Name = customer.Name,
                    Surname = customer.Lastname,
                    Email = customer.Email,
                    Password = Crypto.HashPassword(customer.Password),
                    Birth = customer.Birthdate,
                    IsSubscribe = customer.IsSubscribe,
                    
                };
                _context.Customers.Add(user);
                _context.SaveChanges();
                return Ok(new
                {
                    message = "Your are registered ! Please login to your account"
                });
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
