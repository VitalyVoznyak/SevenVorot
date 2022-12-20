using Microsoft.AspNetCore.Mvc;
using SevenVorot.Models;

namespace SevenVorot.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        
        public Search Check(Search search)
        {
            
            return search;
        }
    }
}
