
//string ad1 = "Ajda";
//string soyad1 = "Pekkan";
//int yas1 = 75;

//string ad2 = "Tarkan";
//string soyad2 = "Tevetoğlu";
//int yas = 40;





using OOP_Giris;
using System.Reflection.Metadata;

Kisi kisi1 = new Kisi(); // New'lemek - Nesne Oluşturmak - Instance almak. -> Hepsi aynı.

kisi1.Ad = "Ajda";
kisi1.Soyad = "Pekkan";
kisi1.Yas = 75;

// Daha pratik yoldan nesne oluşturma  ve değer atama, her defasında kisi2. yazmaya gerek duymuyoruz.
Kisi kisi2 = new Kisi
{
    Ad = "Tarkan",
    Soyad = "Tevetoğlu",
    Yas = 45
};

// 2 yöntemde de algoritmik sırayla -> Önce nesne oluşturulur sonra değerlera atandı.

// Bir property'e değer atarkan içerisindeki "set" metodunu tetiklersin.

Console.WriteLine("Davetimize hoş geldiniz.");

Console.WriteLine("Davetimizin ilk sanatçısının bilgiler:");
Console.WriteLine("Ad --> " + kisi1.Ad);
Console.WriteLine("Soyad --> " + kisi1.Soyad );
// Değerleri okuma aşamasında propertylerin (Ad ve Soyad propertylerinin) Get metotları tetiklendi.

Kisi kisi3 = new Kisi
{
    Ad = "Sertan",
    Soyad = "Bozkuş",
    Yas = 29
};


kisi1.KendiniTanit(); //  Koruma  seviyesi yüzünden erişilmiyor hatası alırsam bu erişim belirteçleriyle oynamam gerektiği anlamına gelir. Public yaptığım için artık erişebilirim.

Console.WriteLine("---");

kisi2.KendiniTanit();

Console.WriteLine("---");

kisi3.KendiniTanit();

Console.WriteLine("-----------------------------------------------------------");

Kisi denemeKisisi = new Kisi();
Kisi denemeKisisi2 = new Kisi();
Kisi denemeKisisi3 = new Kisi();
Kisi denemeKisisi4 = new Kisi();


Kisi yeniKisi = new Kisi("Pınar", "Yetiş");



// Bu noktadan itibaren bu projeyi kullananın 2 şekilde kişi  oluşturma imkanı var.

// Ya önce boş değerleri olan bir kişi nesnesi oluşturacak ve 2. aşamada değerleri atayacak propertylere

// Ya da nesneyi oluştururken ad ve soyad bilgilerini verip, propertyleri dolu bir şekilde oluşturacak.

// Ad, Soyad, Yaş propertyleri dolu nesne oluşturmaya sağlayan 3. constructor seçeneğini de siz yazın.

