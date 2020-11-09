using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZoNaN.Controllers
{
    public class AboutusController : Controller
    {
        public IActionResult AboutUs()
        {

            return View();
        }
    }
}
