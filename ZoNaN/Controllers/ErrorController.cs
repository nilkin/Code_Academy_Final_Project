using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZoNaN.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Back()
        {
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
