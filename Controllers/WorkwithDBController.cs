using Microsoft.AspNetCore.Mvc;

namespace SevenVorot.Controllers
{
    public class WorkwithDBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProduct()
        {
            return View();
        }
        public IActionResult GetProductInfo()
        {
            return View();
        }
    }
}
