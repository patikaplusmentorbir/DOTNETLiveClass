// GENERIC LIST

// List<T>

// T -> type ---> generic yapı.

// List<int> test = new List<int> { 1, 2, 3, 4 };


using GenericList;

List<int> sayilar = new List<int>();

sayilar.Add(4);
sayilar.Add(10);
sayilar.Add(-20);
sayilar.Add(100);


Console.WriteLine(sayilar);

Console.WriteLine("------ Sayılar Listesinin Elemanları ------");

Console.WriteLine(sayilar[0]);
Console.WriteLine(sayilar[1]);
Console.WriteLine(sayilar[2]);
Console.WriteLine(sayilar[3]);

Console.WriteLine("------------- FOR DÖNGÜSÜ İLE -------------");

for (int i = 0; i < sayilar.Count; i++)
{
    Console.WriteLine(sayilar[i]);
}

Console.WriteLine("----------- FOREACH DÖNGÜSÜ İLE --------------");

foreach (var item in sayilar)
{
    Console.WriteLine(item);
}


Console.WriteLine("----------------------------------------------------------");



List<string> takimlar = new List<string>();

takimlar.Add("Lakers");
takimlar.Add("Buston");
takimlar.Add("Indiana");
takimlar.Add("Golden State");
takimlar.Add("Clippers");

int sayac = 1;
foreach(var takim in takimlar)
{
    
    Console.WriteLine(sayac++ + " -> " + takim);


}

/*
Console.WriteLine("Eklemek istediğiniz takımı giriniz.");
takimlar.Add(Console.ReadLine());
*/
Console.WriteLine("------------------------------------");
List<Sarkici> sarkicilar = new List<Sarkici>();

Sarkici sarkici1 = new Sarkici()
{
    TamAd = "Ajda Pekkan",
    MuzikTurleri = "Türkçe Pop, Alaturka",
    Memleket = "İstanbul / Türkiye"
};

Sarkici sarkici2 = new Sarkici()
{
    TamAd = "Serdar Ortaç",
    MuzikTurleri = "Türkçe Pop",
    Memleket = "Kıbrıs"
};


Sarkici sarkici3 = new Sarkici()
{
    TamAd = "Yalın",
    MuzikTurleri = "Türkçe Pop",
    Memleket = "Kahraman Maraş"
};

sarkicilar.Add(sarkici1);
sarkicilar.Add(sarkici2);
sarkicilar.Add(sarkici3);

foreach (var item in sarkicilar)
{
    Console.WriteLine(item);
}
