using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;

namespace ZoNaN.Filter
{
    public class ProfileInfo : ActionFilterAttribute
    {

        private readonly ZonanDbContext _context;
        public ProfileInfo(ZonanDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            var customer = _context.Customers.FirstOrDefault(u => u.Token == token);

            context.RouteData.Values["Customer"] = customer;

            base.OnActionExecuting(context);
        }
    }
}
