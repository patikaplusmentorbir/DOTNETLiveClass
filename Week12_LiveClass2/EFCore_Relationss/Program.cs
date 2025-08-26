using EFCore_Relationss.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// 3
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<RelationsDbContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

// 1-1
// User
// UserDetail

// 1-x
// Product
// Category

// x-x
// Product
// Order
// Çoka çok bağlantı ortaya yeni bir tablo çıkartır ve bu tablo diğer iki tabloyla 1'e çok bir şekilde bağlantılıdır.