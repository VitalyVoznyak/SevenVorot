using Microsoft.AspNetCore.Mvc;

namespace SevenVorot.Controllers
{
    public class AutomaticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
