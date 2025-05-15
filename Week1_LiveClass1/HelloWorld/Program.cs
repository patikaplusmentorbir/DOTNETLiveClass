Console.WriteLine("Merhaba Dünya");
Console.WriteLine("Benim adım Sertan");
Console.WriteLine("Hoşçakal.");


Console.WriteLine("---------------------------------");

Console.Write("Merhaba Dünya");
Console.Write("Benim adım Sertan\n");


Console.WriteLine("----------------------------------");

string ad;
ad = "Ajda Pekkan";

Console.WriteLine(ad);

ad = Console.ReadLine(); // console.readline kullanıcıdan console üzerinden veri ister.


Console.WriteLine(ad);

Console.WriteLine("------------------------------------");

Console.WriteLine("Yaşınız kaç ?");
int yas = Convert.ToInt32(Console.ReadLine()); // 23

// Convert.ToInt32("234"); --> 234

Console.WriteLine("O halde adınız -> " + ad + " ve yaşınız -> " + yas);
Console.WriteLine("Bir şeyler değiştirdim.");

// Githuba göndermek -> Git tabı -> Create Repository -> ayarları yap push.
// Editlemek -> View tabı -> Git changes -> Commitle ardından push.