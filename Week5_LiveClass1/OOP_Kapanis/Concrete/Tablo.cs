using OOP_Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapanis.Concrete
{
    internal class Tablo : BaseSanatEseri, ITablo, ISanatEseri
    {
        public string RenkPaleti { get; set; } // Kullanılan renkler
        public void Cilala()
        {
            Console.WriteLine(EserAdi + " adlı tablo cilalanıyor.");
        }

        public void DuvaraAs()
        {
            Console.WriteLine(EserAdi + " adlı tablo duvara asılıyor.");
        }

        public void DuvardanKaldir()
        {
            Console.WriteLine(EserAdi + " adlı tablo duvardan kaldırılıyor.");
        }

        public void SatisiniYap()
        {
            Console.WriteLine(EserAdi + " adlı tablonun satışı yapıldı." + "\nSatış Fiyatı --> " + Fiyat);
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine("Kullanılan renkler -> " + RenkPaleti);
        }

        public override void SanatciBilgisiVer()
        {

            Console.WriteLine("Bu resmi " + SanatciAdi + " resmetti.");
        }

       
    }
}
