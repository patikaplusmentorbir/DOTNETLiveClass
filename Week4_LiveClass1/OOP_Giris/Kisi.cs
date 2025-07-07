using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris
{
    // Nesne oluşturma şablonu ( NESNENIN KENDISI DEĞİL !!! ) 
    internal class Kisi
    {
        // Her classın içerisinde en az 1 adet yapıcı metot bulunur. (Constructor)

        // Nesne oluşturulurken zorunlu ve otomatik olarak 1 kere tetiklenir.
        public Kisi() // Default Constructor
        {
            Console.WriteLine("Kişi nesnesi oluşturuluyor.");
        }

        public Kisi(string ad, string soyad) // Alternatif Constructor
        {
            Ad = ad;
            Soyad = soyad;
            // BÜYÜK HARFLİLER YANİ DEĞER ATANANLAR -> PROPERTY
            // küçük harfliler -> metot parametreleri
        }

        // Aynı isimli constructordan birden fazla alternatif oluşturmam -> Method Overloading ( Metotların aşırı yüklenmesi )


        public string Ad { get; set; } // Aynı değişken gibi veri tutmaya yarar. PascalCasing isimlendirilir.

        public string Soyad { get; set; }

        public int Yas { get; set; }

        public void KendiniTanit()
        {
            Console.WriteLine("Merhaba ben " + Ad + " " + Soyad); // Her kişi kendi property alanında tutulan değeri söylecek. O nedenle kisi1.Ad - kisi2.Soyad gibi kullanım class içerisinde yok.
        }
    }
}
