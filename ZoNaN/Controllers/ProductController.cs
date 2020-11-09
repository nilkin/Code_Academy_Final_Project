using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZoNaN.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult productGrid()
        {
            return View();
        }
        public IActionResult productSingle()
        {
            return View();
        }
        public IActionResult compare()
        {
            return View();
        }
    }
}
