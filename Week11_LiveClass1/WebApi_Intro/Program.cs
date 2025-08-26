var builder = WebApplication.CreateBuilder(args);

// Controller kullanaca??m :
builder.Services.AddControllers();

// Swagger i�in:
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Swagger i�in:
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// api i�in gerekli :
app.MapControllers();
app.UseHttpsRedirection(); 

app.Run();
