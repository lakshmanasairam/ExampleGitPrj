﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExampleGitPrj.Controllers
{
    public class LakshmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
