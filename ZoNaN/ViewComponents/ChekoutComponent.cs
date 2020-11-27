using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Services;
using ZoNaN.ViewModels;

namespace ZoNaN.ViewComponents
{
    public class ChekoutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            CartViewModel model;
            if (cart == null || cart.Count == 0)
            {
                model = null;
            }
            else
            {
                model = new CartViewModel
                {
                    CartItems = cart,
                    GrandTotal = cart.Sum(x => x.Price * x.Quantity)
                };
            }
            return View(model);
        }
    }
}
