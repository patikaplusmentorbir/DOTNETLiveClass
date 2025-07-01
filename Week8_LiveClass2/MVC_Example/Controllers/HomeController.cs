using Microsoft.AspNetCore.Mvc;
using MVC_Example.Models;

namespace MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var sarkici = new Sarkici()
            {
                Ad = "Ajda",
                Soyad = "Pekkan",
                Yas = 70,
                Deger = 320000.23m
            };

            ViewBag.Tarih = DateTime.Now;

            return View("Index", sarkici);
        }

        public IActionResult About()
        {
            return View("CompanyInfo"); // Action adı ile geriye dönülen View adı farklı olduğu için parametre ile belirtmem gerekiyor.
        }
        
       
    }
}
