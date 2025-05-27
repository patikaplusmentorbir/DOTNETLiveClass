// Konsol ekranından 2 adet sayı alıp bunları önce çarpma metoduna gönderiniz ardından çarpmadan gelen sonucu cift olup olmama metoduna gönderiniz. Metottan gelen true ya da false bilgisine göre ekrana tektir ya da çifttir yazdırınız.

int SayilariCarp(int x, int y)
{
    return x * y;
}

bool CiftMi(int sayi)
{
    int kalan = sayi % 2;

    if (kalan == 0)
    {
       
        return true;
    }


    return false;
}

Console.WriteLine("Birinci sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = SayilariCarp(sayi1, sayi2);
Console.WriteLine("Sayıların çarpımı -> " + sonuc);

if (CiftMi(sonuc))
{
    Console.WriteLine("Sayınız çifttir");
}
else
{
    Console.WriteLine("Sayınız tektir.");
}