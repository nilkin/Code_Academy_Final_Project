﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZoNaN.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult cart()
        {
            return View();
        }
        public IActionResult wish()
        {
            return View();
        }
    }
}
