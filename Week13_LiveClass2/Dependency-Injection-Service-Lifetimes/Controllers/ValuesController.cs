using Dependency_Injection_Service_Lifetimes.Managers;
using Dependency_Injection_Service_Lifetimes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace Dependency_Injection_Service_Lifetimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // bir classın içerisinde bir başka classa ait metodu kullanmak -> Dependency Injection

        // Bağımlılıkları azaltır.

        //private readonly ISiramatik _siramatik;

        //public ValuesController(ISiramatik siramatik) // Constructor Injection
        //{
        //    _siramatik = siramatik;
            
        //}

        [HttpGet]
        public IActionResult Get(int sayi = 1)
        {
            //var siraNumarasi = _siramatik.SiraNumarasiAl();

            //return Ok(siraNumarasi);

            var siraNumaralari = new List<int>();

            for (int i = 0; i<sayi; i++)
            {

                var siramatik = HttpContext.RequestServices.GetRequiredService<ISiramatik>();
                // Service Locator Pattern
                // Bu bir http isteği değil
                // O nedenle Scoped burada yeni nesne vermez, eskisinden devam eder.
                // Transient Http isteği olsun olmasın her istekte yeni nesne vereceğinden, burada yeni nesne verir ve sıfırlanır.

                var siraNumarasi = siramatik.SiraNumarasiAl();

                siraNumaralari.Add(siraNumarasi);



            }

            return Ok(siraNumaralari);

        }

       
    }
}
