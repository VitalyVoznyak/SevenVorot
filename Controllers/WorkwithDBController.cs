using Microsoft.AspNetCore.Mvc;
using SevenVorot.ContextFolder;
using SevenVorot.Models;
using System.Linq;
using System.Text.Json;

namespace SevenVorot.Controllers
{
    public class WorkwithDBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct(Product product)
        {
            if (product.Name != null) 
            {
                 using (DataContext db = new DataContext())
                {
                    db.products.Add(product);
                    db.SaveChanges();
                    Console.WriteLine("Данные занесены в базу");
                    Product[] automaticProducts = db.products.Where(p => p.Partition == "Автоматика").ToArray();
                    foreach (Product ap in automaticProducts)
                    {
                        Console.WriteLine(ap.Name);
                        Console.WriteLine(ap.Id);
                        Console.WriteLine(ap.ImageName);
                        Console.WriteLine(ap.Partition);
                        Console.WriteLine(ap.SecondPartition);
                        Console.WriteLine(ap.Article);
                    }
                }
            }
            ModelState.Clear();
            return View();
        }
    }
}

