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
    public class CompareIconBagdeComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<CompareItem> Compare = HttpContext.Session.GetJson<List<CompareItem>>("Compare");
            CompareViewModel model;
            if (Compare == null || Compare.Count == 0)
            {
                model = null;
            }
            else
            {
                model = new CompareViewModel
                {
                    CmprItems = Compare,
                };
            }
            return View(model);
        }
    }
}
