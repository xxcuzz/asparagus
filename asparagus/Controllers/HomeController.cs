﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asparagus.Models;
using asparagus.Data;
using Microsoft.AspNetCore.Identity;

namespace asparagus.Controllers {
    public class HomeController : Controller {

        private ApplicationDbContext _application;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext application) {
            _logger = logger;
            _application = application;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Eat() {
            return View();
        }

        public IActionResult Feed() {
            return View(_application.Users);
        }

        public void UserAte() {
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
