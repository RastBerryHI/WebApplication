using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();

        public ActionResult Index()
        {
            // Извлекаем данные из таблицы Phones   
            IEnumerable<Phone> phones = phoneContext.Phones;

            // Записываем phpnes в динамическое свойство ViewBag
            ViewBag.Phones = phones;

            return View();
        }

        // Данный метод контроллера будет срабатывать при Get запросе на контроллер
        [HttpGet]
        public ActionResult Buy(int id) 
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase) 
        {
            purchase.DateTime = DateTime.Now;

            phoneContext.Purchases.Add(purchase);

            phoneContext.SaveChanges();

            return $"Уважаемый покупатель, {purchase.FIO}, с вами скоро свяжутся!";
        }
    }
}