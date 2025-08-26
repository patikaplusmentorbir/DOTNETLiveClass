using Dependency_Injection_Service_Lifetimes.Managers;
using Dependency_Injection_Service_Lifetimes.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// SERVICE LIFETIMES
// Ben Interface tipinde istediğimde sen concrete olan classtan newle ve gönder.

//builder.Services.AddSingleton<ISiramatik, Siramatik>(); // Her istekte Aynı nesne
//builder.Services.AddScoped<ISiramatik, Siramatik>(); // Her http isteğinde ayrı nesne
builder.Services.AddTransient<ISiramatik, Siramatik>(); // Her istekte ayrı nesne.




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
