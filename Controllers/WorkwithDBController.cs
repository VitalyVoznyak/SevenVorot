using Microsoft.AspNetCore.Mvc;
using SevenVorot.ContextFolder;
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
            product.otherSpecificationsNamesJson = product.CreateJsonFromStrings(product.otherSpecificationsNameArray);

            product.otherSpecificationsValuesJson = product.CreateJsonFromStrings(product.otherSpecificationsValueArray);

            using (DataContext db = new DataContext())
                 {
                     db.Add(product);
                     db.SaveChanges();
                 }
            return View();
        }
       
    }
}
