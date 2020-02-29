using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using asparagus.Data;
using asparagus.Models;

namespace asparagus.Controllers {
    public class EatingsListsController : Controller {
        private readonly asparagusContext _context;

        public EatingsListsController(asparagusContext context) {
            _context = context;
        }

        // GET: EatingsLists
        public async Task<IActionResult> Feed() {
            return View(await _context.EatingsList.ToListAsync());
        }

        // GET: EatingsLists/Create
        public IActionResult Create() {
            return View();
        }

       /* public IActionResult Feed() {
            var notes = _context.EatingsList.OrderByDescending(s => s.EatingDate);

            return View(notes);
        }*/

        // POST: EatingsLists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,EatingDate,Counter")] EatingsList eatingsList) {
            if (ModelState.IsValid) {
                _context.Add(eatingsList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eatingsList);
        }

        private bool EatingsListExists(int id) {
            return _context.EatingsList.Any(e => e.Id == id);
        }
    }
}
