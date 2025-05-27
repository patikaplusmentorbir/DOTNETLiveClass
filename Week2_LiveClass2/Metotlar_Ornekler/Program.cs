
// Kullancıya adını ve soyadını soran, kullanıcıdan bu cevapları alan ve hoş geldiniz + ad + soyad şeklinde işlem yapan bir metot.

//void SelamVer()
//{

//    Console.WriteLine("Adınız nedir?");
//    string ad = Console.ReadLine();

//    Console.WriteLine("Soyadınız nedir?");
//    string soyad = Console.ReadLine();

//    Console.WriteLine($"Hoş geldin {ad} {soyad}");



//}

//// Metodu 4 kez çağıralım.
//for (int i = 0; i<4; i++)
//{
//    SelamVer();
//}


// Parametre olarak dışarıdan bir sayı alan ve bu sayının tek mi yoksa çift mi olduğunu bir mesajla dönen metot.

string TekMiCiftMi(int sayi)
{
    string mesaj = "";

    if (sayi % 2 == 0)
        mesaj = "Sayınız bir çift sayıdır.";
    else
        mesaj = "Sayınız bir tek sayıdır.";


    return mesaj;

}

Console.WriteLine("Bir sayı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());


string mesaj = TekMiCiftMi(sayi);
Console.WriteLine(mesaj);



// Ödev -> 3 ürün fiyatı alan ve bunların toplam  değerini hesaplayan, ardından indirimsiz fiyat = .... şeklinde kullanıcı için konsola bir metot.

//  -> Bir total fiyat alıp buna 20% indirim uygulayan bir metot. Ardından indirimli fiyatı ekrana yazdırıyor.


// -> Bir total fiyat bir de indirim miktarı alıp ( 10 / 20 / 30 gibi ) ve bu belirtilen oranda indirim yapıp fiyatı ekrana yazdıran metot.

