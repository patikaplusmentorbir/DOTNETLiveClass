
// Metot tanımlarken

// [MetotTipi] [MetotAdı] ( [Parametreler] )
// {
//    İşlemler
//    return ( sonuç )
// }

int Topla(int x , int y)
{
    int toplam = x + y;

    return toplam;

}


// Metot kullanımı

int sonuc = Topla(2, 4);
Console.WriteLine("İşleminizin sonucu " + sonuc);

Console.WriteLine("--------------------------------------------");

void TestMetodu()
{
    Console.WriteLine("Merhaba");
    Console.WriteLine("Nasılsın");
    Console.WriteLine("İyi günler");
    Console.WriteLine("^^");
}

TestMetodu();
TestMetodu();
TestMetodu();
TestMetodu();