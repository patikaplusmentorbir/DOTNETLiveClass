//1.Konsola "Merhaba Dünya" yazdıran bir program yazın.

//Console.WriteLine("Merhaba Dünya");

//2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.

//int sayi1, sayi2;

//Console.WriteLine("Birinci sayıyı giriniz.");
//sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("İkinci sayıyı giriniz.");
//sayi2 = Convert.ToInt32(Console.ReadLine());

//int toplam = sayi1 + sayi2;

//Console.WriteLine("Sayıların toplamı -> " + toplam);

//3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.



//Console.WriteLine("Yaşınız kaç ?");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("Yetişkinsiniz.");
//}
//else
//{
//    Console.WriteLine("Çocuksunuz xd.");
//}



//4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
// Değişken isimlendirme -> camelCasing    ! PascalCasing Değil.
using System.ComponentModel.Design;

//Console.WriteLine("Bir tam sayı giriniz.");
//int tamSayi = Convert.ToInt32(Console.ReadLine());
//int bolumundenKalan = tamSayi % 2;

//if(bolumundenKalan == 0)
//{
//    Console.WriteLine("Sayınız çifttir.");
//}
//else
//{
//    Console.WriteLine("Sayınız tektir.");
//}


//5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.

//Console.WriteLine("Derece giriniz.");
//int derece = Convert.ToInt32(Console.ReadLine());


//if(derece < 0)
//{
//    Console.WriteLine("Donuyor!");
//}
//else if ( derece >= 0 && derece <= 30)
//{
//    Console.WriteLine("Normal");
//}
//else
//{
//    Console.WriteLine("Çok Sıcak!");
//}

//6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.

//Console.WriteLine("Bir sayı giriniz.");
//int gun = Convert.ToInt32(Console.ReadLine());

//if(gun == 1)
//{
//    Console.WriteLine("Pazartesi");
//}
//else if (gun == 2)
//{
//    Console.WriteLine("Salı");
//}
//else if (gun == 3)
//{
//    Console.WriteLine("Çarşamba");
//}
//else if (gun == 4)
//{
//    Console.WriteLine("Perşembe");
//}
//else if (gun == 5)
//{
//    Console.WriteLine("Cuma");
//}
//else if (gun == 6)
//{
//    Console.WriteLine("Cumartesi");
//}
//else if (gun == 7)
//{
//    Console.WriteLine("Pazar");
//}
//else
//{
//    Console.WriteLine("Geçersiz bir değer.");
//}


//switch (gun)
//{
//	case 1:
//        Console.WriteLine("Pazartesi");
//        break;

//    case 2:
//        Console.WriteLine("Salı");
//        break;

//    case 3:
//        Console.WriteLine("Çarşamba");
//        break;
//    case 4:
//        Console.WriteLine("Perşembe");
//        break;
//    case 5:
//        Console.WriteLine("Cuma");
//        break;
//    case 6:
//        Console.WriteLine("Cumartesi");
//        break;
//    case 7:
//        Console.WriteLine("Pazar");
//        break;
//    default:
//        Console.WriteLine("Geçersiz değer.");
//        break;
//}



//7. Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)

//8. Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.



//9. Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.


//string kayitliSifre = "12345";

//Console.WriteLine("Bir şifre giriniz.");
//string girilenSifre = Console.ReadLine();

//if (kayitliSifre == girilenSifre)
//    Console.WriteLine("Giriş Başarılı");
//else
//    Console.WriteLine("Giriş Başarısız.");

//10. Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.

int sayi1, sayi2;

Console.WriteLine("Birinci sayıyı giriniz.");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İşlem giriniz.");
char islem = Convert.ToChar(Console.ReadLine()); 

if(islem == '+')
{
    Console.WriteLine("Sayıların toplamı -> "+ (sayi1+sayi2));
}
else if (islem == '-')
{
    Console.WriteLine("Sayıların farkı -> " + (sayi1-sayi2));
}
else if(islem == '*')
{
    Console.WriteLine("Sayıların çarpımı " + sayi1*sayi2);
}
else if(islem == '/')
{
    Console.WriteLine("Sayıların bölümü " + sayi1/sayi2);
}
else
{
    Console.WriteLine("Tanımlanmamış bir işlem");
}