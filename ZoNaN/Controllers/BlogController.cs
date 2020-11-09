using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZoNaN.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult blogGrid()
        {
            return View();
        }
        public IActionResult blogSingle()
        {
            return View();
        }
    }
}
