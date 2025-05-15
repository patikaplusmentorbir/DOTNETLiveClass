//  For

//  0 - 1 - 2 - 3 - 4 - 5  ---> Ekrana 6 kere "Merhaba" yazdıran For

//for(int sayac = 0; sayac <=5; sayac++)
//{
//    Console.WriteLine("Merhaba");
//}

//Console.WriteLine("---------------------------------------");

//Console.WriteLine("Oyunumuz başlıyor.");

//for (int i =0; i<3; i++)
//{
//    Console.WriteLine("Bir sayı giriniz");
//    Console.ReadLine();
//}

//Console.WriteLine("---------------------------------------");

// Kullanıcının girdiği sayı tek mi çift mi söyleyen ve 10 tur dönen bir program.

// Kullanıcıdan sayı iste
// Girilen sayıyı  bir değişkende tut
// Değişken içerisinde değerde istenilen kontrolü yap ( x % 2 == 0 )
// Cevabı söyle
// Sayaç durumuna göre işlemi tekrar et.

for (int i =0; i<3; i++)
{
    Console.WriteLine("Bir sayı giriniz.");
    int sayi = Convert.ToInt32(Console.ReadLine()); // "47" --> convertle -> 47

    if(sayi % 2 == 0)
        Console.WriteLine("Sayınız çifttir.");
    else
        Console.WriteLine("Sayınız tektir.");
}


