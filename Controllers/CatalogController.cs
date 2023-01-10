using Microsoft.AspNetCore.Mvc;
using SevenVorot.ContextFolder;
using SevenVorot.Models;
using System.Collections.Generic;

namespace SevenVorot.Controllers
{
    public class CatalogController : Controller
    {

        public ActionResult ProductListPage(int page = 0, string Partition = "Автоматика", string SecondPartition = null, string ThridPartition = null) //метод, возвращающий страницу со списком продуктов
        {
            Console.WriteLine(Partition, SecondPartition,ThridPartition);
            if (SecondPartition == null) { Console.WriteLine("mt"); }
            if (page != 0) { page--; }  //занижаем номер полученной страницы

            using (DataContext db = new DataContext())//используем базу данных
            {
              const int PageSize = 15;  //сколько товаров вмещается на одной странице

                int count;              //посчитаем, сколько всего товаров с определенными характеристиками

                Product[] data;         //модели , которые будут передаваться в представление

                if (ThridPartition != "" && ThridPartition != null)                                                                                                                                                  //
                {                                                                                                                                                                                                    //
                     count = db.products.Where(p => (p.Partition == Partition && p.SecondPartition == SecondPartition  && p.ThridPartition == ThridPartition)).Count();                                              //
                                                                                                                                                                                                                     //
                    data = db.products.Where(p => (p.Partition == Partition && p.SecondPartition == SecondPartition  && p.ThridPartition == ThridPartition)).Skip(page * PageSize).Take(PageSize).ToArray<Product>();//
                }                                                                                                                                                                                                    //
                else if (SecondPartition != "" && SecondPartition != null)                                                                                                                                           // в зависимости от того сколько у нас подразделов, 
                {                                                                                                                                                                                                    // берем товары из базы данных
                    count = db.products.Where(p => (p.Partition == Partition && p.SecondPartition == SecondPartition)).Count();                                                                                      //
                                                                                                                                                                                                                     //
                    data = db.products.Where(p => (p.Partition == Partition && p.SecondPartition == SecondPartition)).Skip(page * PageSize).Take(PageSize).ToArray<Product>();                                       //
                }                                                                                                                                                                                                    //
                else                                                                                                                                                                                                 //
                {                                                                                                                                                                                                    //
                    count = db.products.Where(p => p.Partition == Partition).Count();                                                                                                                                //
                                                                                                                                                                                                                     //
                    data = db.products.Where(p => (p.Partition == Partition)).Skip(page * PageSize).Take(PageSize).ToArray<Product>();                                                                               //
                }                                                                                                                                                                                                    //

              this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);          //  ищем номер последней страницы

              if (Partition != null)        { ViewBag.Partition = Partition; }                      //
              if (SecondPartition != null)      { ViewBag.SecondPartition = SecondPartition; }      //  пакуем названия раздела и подразделов во ViewBag
              if (ThridPartition != null)            { ViewBag.ThridPartition = ThridPartition; }   //


              page++;                                                                               //  завышаем обратно номер полученной страницы

              this.ViewBag.Page = page; //пакуем номер страницы во ViewBag

              return this.View(data);
            }
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
    }
}
