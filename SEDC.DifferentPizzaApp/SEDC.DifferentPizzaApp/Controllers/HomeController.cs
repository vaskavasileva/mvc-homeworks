﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess;

namespace SEDC.DifferentPizzaApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            
            return View();
        }

        

    }
}
