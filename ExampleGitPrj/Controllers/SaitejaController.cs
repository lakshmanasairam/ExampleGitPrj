﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExampleGitPrj.Controllers
{
    public class SaitejaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
