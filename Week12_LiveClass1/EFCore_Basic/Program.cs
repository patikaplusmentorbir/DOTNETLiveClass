var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


// 1 -> Entities Klas�r� : 
// Veritaban? tablolar?na d�n�?ecek olan classlar?m? tan?ml?yorum.
// Dikkat : Entity i�erisinde Id kolonu oldu?una emin ol. (Identity)

// 2 -> ?lgili K�t�phaneleri indirmek :
// EntityFrameworkCore.SqlServer ve EntityFrameworkCore.Tools indir.
// Ek : .Design Tools ile birlikte �ekildi?inden ?imdilik indirmiyoruz.

// 3 -> Context s?n?f?n? olu?turmak :
// Context diye bir klas�rde bir class olu?turup DbContext'ten miras al?yorum.

// 4 -> Gerekli Metodu Override Et ve Connection String:
// OnConfiguring metodu i�erisinde .UseSqlServer metoduyla ConnectionStringi belirtiyorum.

// 5 -> DbSet tan?mlama :
// Hangi classlar?m?n veritaban? tablosuna d�n�?mesini istiyorsam Property olarak Context class? i�erisinde tan?ml?yorum.

// 6 -> Migration At , DB'yi g�ncelle.
// add-migration diyerek snapshot al?yorum. Update-Database diyerek c# taraf?nda yapt???m i?lemleri Db'de uyguluyorum.