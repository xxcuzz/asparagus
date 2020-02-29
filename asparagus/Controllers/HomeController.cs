using System;
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
        UserManager<ApplicationUser> _userManager;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext application, UserManager<ApplicationUser> userManager) {
            _logger = logger;
            _application = application;
            _userManager = userManager;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Eat() {
            return View();
        }

        public IActionResult Feed() {
            var users = _application.Users.OrderByDescending(s => s.EatingDate);

            return View(users);
        }

        public IActionResult UserAte() {
            var userId = _userManager.GetUserId(User);

            ApplicationUser user = _application.Users.First(x => x.Id == userId);
            user.Counter++;
            user.EatingDate = DateTime.Now;

            _application.SaveChanges();

            return RedirectToAction("Feed");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
