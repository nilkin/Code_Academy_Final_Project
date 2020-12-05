using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using ZoNaN.Data;

namespace ZoNaN.Filter
{
    public class AdminProfile : ActionFilterAttribute
    {

        private readonly ZonanDbContext _context;
        public AdminProfile(ZonanDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            var user = _context.Users.FirstOrDefault(u => u.Token == token);

            context.RouteData.Values["User"] = user;

            base.OnActionExecuting(context);
        }
    }
}
