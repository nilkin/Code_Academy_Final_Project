using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;

namespace ZoNaN.Filter
{
    public class Auth: ActionFilterAttribute
    {
        private readonly ZonanDbContext _context;
        public Auth(ZonanDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool hasToken = context.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            if (!hasToken)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "account" }));
            }

            var customer = _context.Customers.FirstOrDefault(u => u.Token == token);

            if (customer == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "account" }));
            }

            context.RouteData.Values["Customer"] = customer;

            base.OnActionExecuting(context);
        }    }
}
