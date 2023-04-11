using Microsoft.AspNetCore.Mvc;
using ReadingRoom.Models;
using System.Diagnostics;

namespace ReadingRoom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        { 
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Random(string? x )
        {


            var movie = new Class() { Name = x };

            ViewData["Movie"] = movie;

            return View(movie);

        }

        public IActionResult Edit(int ID)
        {
            return Content("id = " + ID); 

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}