﻿using Anyar.DAL;
using Anyar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anyar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
 
      
        public IActionResult Index()
        {
           return View();
        }
    }
}
