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
    public class IconBadgeComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<BasketItem> cart = HttpContext.Session.GetJson<List<BasketItem>>("Cart");
            BadgeIconViewModel model;
            if (cart == null || cart.Count == 0)
            {
                model = null;
            }
            else
            {
                model = new BadgeIconViewModel
                {
                    CartItems = cart,
                };
            }
            return View(model);
        }
    }
}
