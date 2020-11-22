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
    public class WishNavComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            CartViewModel model;
            if (wish == null || wish.Count == 0)
            {
                model = null;
            }
            else
            {
                model = new CartViewModel
                {
                    WishItems = wish,
                };
            }
            return View(model);
        }
    }
}

