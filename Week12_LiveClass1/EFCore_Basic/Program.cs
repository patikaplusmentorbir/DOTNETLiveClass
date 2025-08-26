var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


// 1 -> Entities Klasörü : 
// Veritaban? tablolar?na dönü?ecek olan classlar?m? tan?ml?yorum.
// Dikkat : Entity içerisinde Id kolonu oldu?una emin ol. (Identity)

// 2 -> ?lgili Kütüphaneleri indirmek :
// EntityFrameworkCore.SqlServer ve EntityFrameworkCore.Tools indir.
// Ek : .Design Tools ile birlikte çekildi?inden ?imdilik indirmiyoruz.

// 3 -> Context s?n?f?n? olu?turmak :
// Context diye bir klasörde bir class olu?turup DbContext'ten miras al?yorum.

// 4 -> Gerekli Metodu Override Et ve Connection String:
// OnConfiguring metodu içerisinde .UseSqlServer metoduyla ConnectionStringi belirtiyorum.

// 5 -> DbSet tan?mlama :
// Hangi classlar?m?n veritaban? tablosuna dönü?mesini istiyorsam Property olarak Context class? içerisinde tan?ml?yorum.

// 6 -> Migration At , DB'yi güncelle.
// add-migration diyerek snapshot al?yorum. Update-Database diyerek c# taraf?nda yapt???m i?lemleri Db'de uyguluyorum.