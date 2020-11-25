using System;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoNaN.Data;
using ZoNaN.Models;
using ZoNaN.ViewModels;
using Microsoft.AspNetCore.Http;
using ZoNaN.Filter;
using ZoNaN.Services;
using System.Collections.Generic;
using ZoNaN.Data.Models;

namespace ZoNaN.Controllers
{ [TypeFilter(typeof(ProfileInfo))]
    public class AccountController : Controller
    {
       
        private readonly ZonanDbContext _context;
        private Customer Users => RouteData.Values["Customer"] as Customer;
        public AccountController(ZonanDbContext context)
        {
            _context = context;
        }
        [TypeFilter(typeof(Auth))]
        public async Task<IActionResult> Profile()
        {

            ProfileViewModel model = new ProfileViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsProfile == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> Login()
        {

            LoginViewModel model = new LoginViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsLogin == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(CustomerLoginViewModel customer)
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
        }
        public async Task<IActionResult> Register()
        {

            RegisterViewModel model = new RegisterViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsRegister == true).FirstOrDefaultAsync(),
            };
            return View(model);
        }
        [HttpPost]  
        public IActionResult Register(CustomerRegisterViewModel customer)
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

        public async Task<IActionResult> Chekout()
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            ChekoutViewModel model = new ChekoutViewModel 
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsChekout == true).FirstOrDefaultAsync(),

            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Chekout(ChekPayViewModel chekPay)
        {
            if (chekPay == null)
            {
                return BadRequest(new
                {
                    message = "Some of inputs is empty, Please enter information correctly"
                });
            }

            //List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            //foreach (var item in cart)
            //{
            //    Order orders = new Order
            //    {
            //        ProductId = item.Id,
            //        Name = item.Name,
            //        Quantity = item.Quantity,
            //        Price = item.Price,
            //        Total = item.Total,
            //        Photo = item.Photo
            //    };
            //    await _context.Orders.AddAsync(orders);
            //    _context.SaveChanges();
            //}
            //if (cart.Count == 0)
            //{
            //    HttpContext.Session.Remove("Cart");
            //}
            Chekout model = new Chekout
            {
                Gender = chekPay.Gender,
                Name = chekPay.Name,
                Surname = chekPay.Surname,
                Email = chekPay.Email,
                City = chekPay.City,
                Address = chekPay.Address,
                PaymentMethod = chekPay.PaymentMethod,
                Payment = chekPay.Payment,
                Shipping = chekPay.Shipping,
                Message = chekPay.Message
            };
            await _context.Chekouts.AddAsync(model);
            _context.SaveChanges();
            return Ok(new
            {
                message = "Your are registered ! Please login to your account"
            });
        }
        public IActionResult Logout()
        {
            var profile = _context.Customers.Find(Users.Id);
            profile.Token = null;
            _context.SaveChangesAsync();
            return Redirect("/");
        }
    }
}
