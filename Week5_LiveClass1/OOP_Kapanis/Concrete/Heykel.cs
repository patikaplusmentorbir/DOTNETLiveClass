using OOP_Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapanis.Concrete
{
    internal class Heykel : BaseSanatEseri, IHeykel, ISanatEseri
    {
        public string TasTipi { get; set; }
        public void Parlat()
        {
            Console.WriteLine(EserAdi + "adlı heykel parlatılıyor.");
        }

        public void SatisiniYap()
        {
            Console.WriteLine(EserAdi + "adlı heykelin satışı yapıldı." + "\nSatış Fiyatı -> " + Fiyat);
        }

        public void TezgahaCikar()
        {
            Console.WriteLine(EserAdi + "adlı heykel tezgaha çıkartıldı.");
        }

        public void TezgahtanAl()
        {
            Console.WriteLine(EserAdi + "adlı heykel tezgahtan alındı.");
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine("Taş Tipi --> " + TasTipi);
        }

        public override void SanatciBilgisiVer()
        {
            Console.WriteLine("Bu heykeli " + SanatciAdi + " yonttu.");
        }

        
    }
}
