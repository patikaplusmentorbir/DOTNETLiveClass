 // MVC -> Model, View, Controller

var builder = WebApplication.CreateBuilder(args);


//  buildier ile yazılacak işlemler builder.Build() kodundan önce yazılmalı.

builder.Services.AddControllersWithViews();
//  Bu proenin viewleri ve controllerları olan bir proje olduğunu söylüyoruz.

var app = builder.Build();

// Uri üzerinden hangi formatla istek atılacağını belirtiyoruz.
app.MapControllerRoute(
    name : "default",
    pattern :"{controller=Home}/{action=Index}" 
    
    
    );
// Controller içerisindeki metot ---> Action
// Default Routing ile hiçbir controller / action bildirilmezse otomatik nereye istek atılacağını belirledik.


// app ile ilgili yazılacak olanlar app.Run() kodundan önce yazılmalı.

app.Run();
