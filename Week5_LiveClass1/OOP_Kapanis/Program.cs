
// SANAT GALERISI

// Tablo - Heykel ---> SanatEseri

// Abstract - Concrete

using OOP_Kapanis.Abstract;
using OOP_Kapanis.Concrete;

    List<Heykel> heykeller = new List<Heykel>();
    List<Tablo>  tablolar = new List<Tablo>();
    List<BaseSanatEseri> sanatEserleri = new List<BaseSanatEseri>();


while (true)
{

  soru:  Console.WriteLine("Tablo eklemek için 1 , Heykel eklemek için 2'yi giriniz.");
    string karar = Console.ReadLine();
    if( karar == "1")
    {
        Tablo yeniTablo = new Tablo();

        Console.WriteLine("Tablonun adını giriniz.");
        yeniTablo.EserAdi = Console.ReadLine();

        Console.WriteLine("Açıklama ekleyiniz.");
        yeniTablo.Aciklama = Console.ReadLine();

        Console.WriteLine("Fiyat bilgisi giriniz.");
        yeniTablo.Fiyat = Convert.ToDecimal(Console.ReadLine());

        tablolar.Add(yeniTablo);
        sanatEserleri.Add(yeniTablo);
    }
    else if (  karar == "2")
    {

        Heykel yeniHeykel = new Heykel();

        Console.WriteLine("Heykelin adını giriniz.");
        yeniHeykel.EserAdi = Console.ReadLine();

        Console.WriteLine("Açıklama ekleyiniz.");
        yeniHeykel.Aciklama = Console.ReadLine();

        Console.WriteLine("Fiyat bilgisi giriniz.");
        yeniHeykel.Fiyat = Convert.ToDecimal(Console.ReadLine());

        heykeller.Add(yeniHeykel);
        sanatEserleri.Add(yeniHeykel);
    }
    else
    {
        Console.WriteLine("Yanlış bir değer girdiniz.");
        goto soru;
    }

    Console.WriteLine("Başka bir eser eklemek  istiyor musunuz? (eklemek için 'e', uygulamayı sonlandırıp, listelerinizin son durumunu görmek için herhangi başka tuşa basınız.)");
    karar = Console.ReadLine();

    if (karar != "e")
        break;

}

Console.WriteLine("--------- TABLOLAR ------------");

foreach (var tablo in tablolar)
{
    Console.WriteLine(tablo.EserAdi);
}


Console.WriteLine("--------- HEYKELLER ---------------");

foreach (var heykel in heykeller)
{
    Console.WriteLine(heykel.EserAdi);
}


Console.WriteLine("---------- BÜTÜN SANAT ESERLERİ ----------");

foreach (var eser in sanatEserleri)
{
    Console.WriteLine(eser.EserAdi);
}