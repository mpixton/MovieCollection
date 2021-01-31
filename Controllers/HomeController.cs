using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: /
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Privacy
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        // GET: /Home/Podcasts
        [HttpGet]
        public IActionResult Podcasts()
        {
            return View();
        }

        // GET: /Home/AddFilm
        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }

        // POST: /Home/AddFilm
        [HttpPost]
        public IActionResult AddFilm(Film film)
        {
            // If the Film passes validaton, add it to the collection.
            // Else, render the AddFilm page with the validation messages.
            if (ModelState.IsValid)
            {
                TempStorage.AddFilm(film);
                return View("Confirmation", film);
            }
            else
            {
                return View(film);
            }
            
        }

        // GET: /Home/FilmCollection
        [HttpGet]
        public IActionResult FilmCollection()
        {
            // Filter Independence Day out of the collection cause its not as American
            // as the Real Most American Movie Ever, Rocky IV.
            return View(TempStorage.Films.Where(f => f.Title != "Independence Day"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
