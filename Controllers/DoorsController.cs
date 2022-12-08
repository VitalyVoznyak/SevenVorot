using Microsoft.AspNetCore.Mvc;

namespace SevenVorot.Controllers
{
    public class DoorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
