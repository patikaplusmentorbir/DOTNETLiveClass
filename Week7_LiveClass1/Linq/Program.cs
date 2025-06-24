

// Linq

// Lambda  => 

using Linq;
using System.Diagnostics.CodeAnalysis;

Func<int, int> kareAl = y => y * y;

Console.WriteLine( kareAl(4) );


Func<int, int> ikiyleCarp = i => i * 2;

int sonuc = ikiyleCarp(10);
Console.WriteLine(sonuc);

Console.WriteLine("----------------------------------------------");


List<string> isimler = new List<string> { "Ajda", "Hande", "Sertab", "Funda", "Gülben" , "Ahmet", "Aslı" , "Abdullah"};

// A ile başlayan elemanları getir.

var aIleBaslayanlar = isimler.Where(x => x.StartsWith("A"));
var aIleBaslayanlar2 = isimler.Where(x => x.Substring(0,1).ToLower() == "a" ); // Büyük küçük harf duyarlılığı kaldırma.

foreach(var item in aIleBaslayanlar)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------");
// 5 harften uzun olanları yazdır.

var yeniListe = isimler.Where(x => x.Length > 5);

foreach (var item in yeniListe)
{
    Console.WriteLine(item);
}


Console.WriteLine("-----------------------");
// 5 harften uzun olanları alfabetik sırayla yazdır.

var yeniListe2 = isimler.Where(x => x.Length > 5).OrderBy(x => x);

foreach(var item in yeniListe2)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------");
// 5 harften uzun olanları alfebatik sırayla ve büyük harflerle yazdır.
// Elemanı yakalayıp işlem yapıp yeni listeye atmak için -> Select
var yeniListe3 = isimler
    .Where(x => x.Length > 5)
    .OrderBy(x => x)
    .Select(x => x.ToUpper());

foreach (var item in yeniListe3)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------");


var ogrenciler = new List<Ogrenci>
{
    new Ogrenci{ Id  = 1, Ad = "Ali",  Not =85 },
    new Ogrenci{ Id = 2, Ad = "Ayşe",  Not = 72},
    new Ogrenci{ Id = 3, Ad = "Mehmet", Not = 48},
    new Ogrenci{ Id = 4, Ad = "Zeynep",  Not = 95}

};

// Not ortalaması 70'ten büyük olan öğrenciler.

var basariliOgrenciler = ogrenciler.Where(x => x.Not > 70);
foreach (var item in basariliOgrenciler)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------");
// Not ortalaması 70'ten büyük olan öğrencileri isimlerine göre sıralayalım.
var siralanmisListe = basariliOgrenciler.OrderBy(x => x.Ad);

foreach (var item in siralanmisListe)
{
    Console.WriteLine(item);
}


Console.WriteLine("---------------------------------");
// Not ortalaması 70'ten büyük olan öğrencileri notlarına göre tersten sıralayalım.

var notaGoreSilanmisListe = basariliOgrenciler.OrderByDescending(x => x.Not);

foreach (var item in notaGoreSilanmisListe)
{
    Console.WriteLine(item + " --> " + item.Not);
}


// Öğrencileri harf notlarına göre gruplayalım.

// A : 85 - 100
// B : 70 - 84
// C : 50 - 69
// D : 0 - 49

string HarfNotu(int not)
{
    if (not >= 85) return "A";
    else if (not >= 70) return "B";
    else if (not >= 50) return "C";
    else return "D";
}


//var ogrenciler = new List<Ogrenci>
//{
//    new Ogrenci{ Id  = 1, Ad = "Ali",  Not =85 },
//    new Ogrenci{ Id = 2, Ad = "Ayşe",  Not = 72},
//    new Ogrenci{ Id = 3, Ad = "Mehmet", Not = 48},
//    new Ogrenci{ Id = 4, Ad = "Zeynep",  Not = 95}

//};
Console.WriteLine("---------------------------------");

var gruplar = ogrenciler.GroupBy(x => HarfNotu(x.Not)); // bir key bir value verir.

foreach (var grup in gruplar)
{
    Console.WriteLine("Harf Notu --> " + grup.Key + ":");

    foreach (var ogrenci in grup)
    {
        Console.WriteLine(ogrenci + " --> " + ogrenci.Not);
    }

}