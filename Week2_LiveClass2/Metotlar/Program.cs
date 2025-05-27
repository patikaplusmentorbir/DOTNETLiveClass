
// 1 -> Değer döndürmeyen parametresiz metotlar.
// 2 -> Değer döndürmeyen parametreli metotlar.
// 3 -> Değer döndüren parametresiz metotlar.
// 4 -> Değer döndüren parametreli metotlar.

// ------------------------------------------------

// 1 -> Değer döndürmeyen parametresiz metotlar.

// Void -> tipi, geriye hiçbir şey dönülmediği anlatır.

// PascalCasing isimlendirme -> İlk harf büyük, her boşluktan sonra yine büyük
using System.Reflection.Metadata;

void SelamVer()
{
    Console.WriteLine("Merhaba öğrenci. Patika+'a hoş geldin.");
}

SelamVer();
SelamVer();
SelamVer();

Console.WriteLine("-------------------------------------------");
// 2 -> Değer döndürmeyen parametreli metotlar.

void SelamVer2(string isim)
{
    Console.WriteLine("Merhaba " + isim + " Patika+'a hoş geldin.");
}

SelamVer2("Ajda Pekkan");
SelamVer2("Banu Alkan");
SelamVer2("Sezen Aksu");

void SelamVer3(string isim,  string soyisim, int x)
{
    Console.WriteLine("Merhaba " +isim + " " + soyisim + " Patika+'a hoş geldin.");
    Console.WriteLine("x değeri -> " + x);
}

SelamVer3("Mustafa", "Kamaci", 5);


// 3 -> Değer döndüren parametresiz metotlar.

string KisininTamAdiniDondur()
{
    //string ad = "Ajda";
    //string soyad = "Pekkan";

    //string tamAd = ad +" "+ soyad;

    //return tamAd;

    return "Ajda Pekkan";
   
}

string sonuc = KisininTamAdiniDondur();
// string sonuc = "Ajda Pekkan";

Console.WriteLine("sonucunuz -> " + sonuc);

Console.WriteLine("- . - . - . - . - . - . - . - . - . - . - . - . - . -");
// 4 -> Değer döndüren parametreli metotlar.

int SayilariTopla(int sayi1, int sayi2)
{
    int toplam = sayi1 + sayi2;
    return toplam;
}

Console.WriteLine(      SayilariTopla(5, 10)    );

int islemSonucu = SayilariTopla(5, 10);
Console.WriteLine(islemSonucu);

