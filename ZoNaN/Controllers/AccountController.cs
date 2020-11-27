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
            if (String.IsNullOrEmpty(customer.Email)&& String.IsNullOrEmpty(customer.Password))
            { 
            return BadRequest(new
                {
                    message = "Some of inputs is empty, Please enter information correctly"
                });
            }
            else
            {                Customer user = await _context.Customers.FirstOrDefaultAsync(u => u.Email == customer.Email); 
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
                        message = "Welcome" + "  " + user.Gender + " " + user.Name
                    });

                    }
                    else
                    {
                        return NotFound(new
                        {
                            message = "This member is not found"
                        });
                    }
            }
                else
                {
                    return NotFound(new
                    {
                        message = "This member is not found"
                    });
                }
            }
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
            if (ModelState.IsValid) {    
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
            return BadRequest(new
            {
                message = "Some of inputs is empty, Please enter information correctly"
            });
        }
        public async Task<IActionResult> Chekout()
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            ChekoutViewModel model = new ChekoutViewModel 
            {
                Breadcrumb = await _context.Breadcrumbs.Where(c => c.IsChekout == true).FirstOrDefaultAsync(),
                TokenUser = Users
            };
            return View(model);
        }
        public IActionResult Logout()
        {
            var profile = _context.Customers.Find(Users.Id);
            profile.Token = null;
            _context.SaveChangesAsync();
            return Redirect("/");
        }
        [HttpPost]
        public async Task<IActionResult> Chekout(ChekPayViewModel chekPay)
        {
            string ChekoutNumber = DateTime.Now.ToString("yyyyMMddHHmmssff");
  
            if (chekPay == null)
            {
                return BadRequest(new
                {
                    message = "Some of inputs is empty, Please enter information correctly"
                });
            }
            if (ModelState.IsValid)
            {
                Chekout model = new Chekout
            {
                Gender = chekPay.Gender,
                Name = chekPay.Name,
                Surname = chekPay.Surname,
                Email = chekPay.Email,
                City = chekPay.City,
                Address = chekPay.Address,
                PaymentMethod = chekPay.PaymentMethod,
                Agreement = chekPay.Agreement,
                Shipping = chekPay.Shipping,
                Message = chekPay.Message,
                ChekoutNumber = ChekoutNumber
            };
            await _context.Chekouts.AddAsync(model);
            _context.SaveChanges();

            HttpContext.Session.SetJson("Chekout", model);

            return Ok(new
            {
                message = "Order is done Please Proceed your Order!"
            });
            }
            return BadRequest(new
            {
                message = "Some of inputs is empty, Please enter information correctly"
            });
        } 
        public async Task<IActionResult> ProceedAsync()
        {  

            ICollection<BasketItem> cart = HttpContext.Session.GetJson<ICollection<BasketItem>>("Cart");
            if (cart==null)
            {
                return NotFound(new { message = "You Basket is empty" });
            }
          
            string OrderNumber = DateTime.Now.ToString("yyyyMMddHHmmssff");

            Chekout chk = HttpContext.Session.GetJson<Chekout>("Chekout");
            if (cart == null)
            {
                return NotFound(new { message = "Please fill The blank before Proceed to Chekout" });
            }

            string chknum = chk.ChekoutNumber;
            Chekout chekoutnum = _context.Chekouts.Where(c => c.ChekoutNumber == chknum).FirstOrDefault();


            foreach (var item in cart)
            {
                Order orders = new Order
                {
                    ProductId = item.Id,
                    Name = item.Name,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    Total = item.Total,
                    Photo = item.Photo,
                    OrderNumber = OrderNumber,
                    ChekoutId = chekoutnum.Id
                };
                await _context.Orders.AddAsync(orders);
                _context.SaveChanges();
                HttpContext.Session.Remove("Cart");
            }

            return Ok(new
            {
                message = "Chekout is done ! We send order info to your Email" 
            });
        }
    }
}
