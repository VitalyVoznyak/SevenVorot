using Microsoft.AspNetCore.Mvc;
using SevenVorot.Models;
using System.Diagnostics;

namespace SevenVorot.Controllers
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
            Search basic = new Search() {searchString = "null" };
            return View(basic);
        }
        
         public IActionResult Automatic()
        {   
            return View();
        }
        public IActionResult Barrier()
        {
            return View();
        }
        public IActionResult Doors()
        {
            return View();
        }
        public IActionResult FencingSystems()
        {
            return View();
        }
        public IActionResult Rollets()
        {
            return View();
        }
        public IActionResult SectionalDoors()
        {
            return View();
        }
        public IActionResult SlidingGates()
        {
            return View();
        }
        public IActionResult SwingGates()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}