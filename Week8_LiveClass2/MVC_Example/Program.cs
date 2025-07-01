var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    
    name: "default",
    pattern: "{controller=home}/{action=index}"
    
    );

app.Run();



// 1 -> Bu projenin bir MVC projesi olduğunu belirtmem gerekiyor. Yani Controller'larım ve bu controllerlardaki actionlardan dönülen View'lerim olacak. -> Builders.Services.AddControllersWithViews();

// 2 -> Her şeyin başı controller -> Controller açıyorum.

// 3 -> Hangi işi yapmak istiyorsan controller içersine o iş için action açıyorum.

// 4 -> Return View() kısmına sağ tıklayarak add view diyip bir view oluşturuyorum. Bu action'a istek atıldığında dönülecek cevap olacak.

// 5 -> Viewlerim için genel bir çerçeve oluşturmak istiyorum. Bu nedenle Shared klasörü açıp içerisinde Layout oluşturacağım.

// 6 -> Sayfalarım Layout kullanacağı için, tek tek üstlerine bunu tanımlamak yerine bir _ViewStart.cshtml sayfasını Views klasörü içerisine oluşturuyorum. (DİKKAT -> İsmi ve yeri tartışmaya kapalıdır.)

// 7 -> app.MapControllerRoute ile bu actionlara nasıl istek atılacağını tanımlıyorum.

// 8 -> Default Routing ile site ilk açıldığında direkt ana sayfaya yönlendirme yapıyorum.