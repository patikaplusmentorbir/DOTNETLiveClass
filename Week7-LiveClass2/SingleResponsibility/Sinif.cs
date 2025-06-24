using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Sinif
    {
        //  Dependency Injection -> Bir classın içerisinde başka classa ait metot kullanmak için.
        //  Bir nevi Siniftan nesne oluşturulduğunda içerisinde ona bağlı otomatik bir eğitmen de new'leniyor.

        private readonly Egitmen _egitmen;
        private readonly Random _random;
        public Sinif(Egitmen egitmen, Random random)
        {
            _egitmen = egitmen;
            _random = random;
        }

        public string SinifNo { get; set; }
        public int Mevcut { get; set; }

        public void SinaviBaslat()
        {
            _random.Next();
            _egitmen.SinavYap();
        }


    }



    internal class Egitmen
    {
        public string AdSoyad { get; set; }
        public string Brans { get; set; }

        public void DersAnlat()
        {
            Console.WriteLine("Öğretmen ders anlatıyor.");

        }

        public void SinavYap()
        {
            Console.WriteLine("Öğretmen sınav yapıyor.");
        }
    }
}
