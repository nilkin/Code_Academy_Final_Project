using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;

namespace ZoNaN.Filter
{
    public class AdminAuth : ActionFilterAttribute
    {

        private readonly ZonanDbContext _context;
        public AdminAuth(ZonanDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool hasToken = context.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            if (!hasToken)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "admin", area = "manager" }));
            }

            var user = _context.Users.FirstOrDefault(u => u.Token == token);

            if (user == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "admin", area = "manager" }));
            }

            if (user.Position != "admin")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "Error", controller = "Error", area = "" }));
            }

            context.RouteData.Values["User"] = user;

            base.OnActionExecuting(context);
        }
    }
}
