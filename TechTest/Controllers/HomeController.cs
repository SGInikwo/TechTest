using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechTest.Data;
using TechTest.Models;

namespace TechTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        //Database context
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Index few
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results()
        {
            IEnumerable<NumberList> objList = _db.NumberLists;
            return View(objList);
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NumberList obj)
        {
            if (ModelState.IsValid)
            {
                _db.NumberLists.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
