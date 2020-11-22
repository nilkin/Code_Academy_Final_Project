using Microsoft.AspNetCore.Http;
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
    public class WishIconBadgeComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<BasketItem> wish = HttpContext.Session.GetJson<List<BasketItem>>("Wish");
            WishBadgeIconViewModel model;
            if (wish == null || wish.Count == 0)
            {
                model = null;
            }
            else
            {
                model = new WishBadgeIconViewModel
                {
                    WishItems = wish,
                };
            }
            return View(model);
        }
    }
}
