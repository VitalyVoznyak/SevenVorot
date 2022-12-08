using Microsoft.AspNetCore.Mvc;

namespace SevenVorot.Controllers
{
    public class FencingSystemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
