using Microsoft.AspNetCore.Mvc;

namespace MVC_Hello.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
            // Action adı olan Index ile dönülecek view Index.cshtml aynı isimde olduğundan return View("Index") yazmak yerine parametresiz çağırabiliyoruz.

        }

        public DateTime Tarih()
        {

            return DateTime.Now;
        }

        public IActionResult ContactPage()
        {
            return View("test");
        }
        

        
    }
}
