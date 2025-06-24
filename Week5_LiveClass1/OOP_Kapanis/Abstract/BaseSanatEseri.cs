using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapanis.Abstract
{
    internal abstract class BaseSanatEseri
    {
        public BaseSanatEseri() 
        {
            KayitTarihi = DateTime.Now;
        }
        public DateTime KayitTarihi { get; set; }
        public string EserAdi { get; set; }
        public string Aciklama { get; set; }
        public string SanatciAdi { get; set; }
        public decimal Fiyat { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine("Eserin Kayıt Tarihi --> " +  KayitTarihi );
            Console.WriteLine("Eser Adı --> " +  EserAdi);
            Console.WriteLine("Açıklama --> " + Aciklama);
            Console.WriteLine("Sanatçısı --> " + SanatciAdi);
            Console.WriteLine("Fiyatı --> "  + Fiyat);
        }

        public abstract void SanatciBilgisiVer(); // abstraction ile gövdeyi gizledim.
        // virtual yapmadım çünkü gövdeye ne yazarsam yazayım alt classların tamamında ezilip değiştiriliyordu. Gövdeye gerek yoktu.
        
        
    }
}
