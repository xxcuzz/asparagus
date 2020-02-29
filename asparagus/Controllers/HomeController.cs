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
using Microsoft.EntityFrameworkCore;

namespace asparagus.Controllers {
    public class HomeController : Controller {

        private ApplicationDbContext _application;
        private EatingListDbContext _eating;
        UserManager<ApplicationUser> _userManager;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext application, UserManager<ApplicationUser> userManager,EatingListDbContext eating) {
            _logger = logger;
            _application = application;
            _userManager = userManager;
            _eating = eating;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Eat() {
            return View();
        }

        public async Task<IActionResult> Users() {
            return View(await _application.Users.ToListAsync());
        }

        public IActionResult Feed() {
            var notes = _eating.EatingNote.OrderByDescending(s => s.EatingDate);

            return View(notes);
        }

        public IActionResult UserAte() {
            var userId = _userManager.GetUserId(User);

            ApplicationUser user = _application.Users.First(x => x.Id == userId);
            user.Counter++;

            _application.SaveChanges();

            EatingsList eatingNote = new EatingsList {
                Counter = user.Counter,
                EatingDate = DateTime.Now,
                Name = user.UserName.Substring(0, user.UserName.IndexOf('@'))

            };
            _eating.Update(eatingNote);
            _eating.SaveChanges();

            return RedirectToAction("Feed");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
