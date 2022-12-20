using Microsoft.AspNetCore.Mvc;
using SevenVorot.Entitys;

namespace SevenVorot.Controllers
{
    public class WorkwithDBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProduct(Product product)
        {
            
            return View();
        }
       
    }
}
