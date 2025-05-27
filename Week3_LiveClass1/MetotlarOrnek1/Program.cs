
// Konsola "Bir yanımız yaprak döker bir yanımız bahar bahçe" yazdıran bir metot.

void GununSozunuYaz()
{
    Console.WriteLine("Bir yanımız yaprak döker. Bir yanımız bahar bahçe.");
}

GununSozunuYaz();
GununSozunuYaz();
GununSozunuYaz();
Console.WriteLine("-------------------------------------------");

string GununSozunuVer()
{
    return "Uzanmışım kumsala, güneş damlar içime.";
}

string gununSozu = GununSozunuVer();
Console.WriteLine(gununSozu);

Console.WriteLine("-------------------------------------");

double PiSayisi()
{
    return 3.14; // float - double - decimal
}

double piSayisi = PiSayisi(); // değişkene çekip kullanmak istersem.

Console.WriteLine("Yarıçapı 3 birim olan çemberin alanı -> " + PiSayisi() * 3 * 3);
Console.WriteLine("Projemiz süresince pi sayısı değeri olarak -> " + piSayisi + " kullanılacaktır.");

// Parametre olarak alınan sayının çift olup olmadığı bilgisini dönen metot.

bool CiftMi(int sayi)
{
    if (sayi % 2 == 0)
    {
        return true;
    }

    return false;

}

Console.WriteLine("Çift mi kontrolü yapmak istediğiniz sayıyı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());


if (  CiftMi(sayi) )
{
    Console.WriteLine("Sayınız çifttir.");
}
else
{
    Console.WriteLine("Sayınız çift değildir.");
}
Console.WriteLine("------------------------------------");

// Ekrana 3 tane rastgele sayı yazdıran metot.

void RastgeleSayiYazdir()
{

    Random rnd = new Random();

    for (int i = 0; i < 3; i++)
    {
        int rastgeleSayi = rnd.Next(1, 21);
        Console.WriteLine(rastgeleSayi);
    }

   
}

RastgeleSayiYazdir();