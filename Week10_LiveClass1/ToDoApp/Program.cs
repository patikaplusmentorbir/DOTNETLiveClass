var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"

    );

// app.MapDefaultControllerRoute(); // Yukar?daki uzun kod yerine art?k bu kullan?labilir.

app.Run();
