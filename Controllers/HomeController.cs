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
            TempStorage.AddFilm(film);
            return View("Confirmation", film);
        }

        // GET: /Home/FilmCollection
        [HttpGet]
        public IActionResult FilmCollection()
        {
            return View(TempStorage.Films);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
