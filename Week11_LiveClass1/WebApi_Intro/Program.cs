var builder = WebApplication.CreateBuilder(args);

// Controller kullanaca??m :
builder.Services.AddControllers();

// Swagger için:
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Swagger için:
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// api için gerekli :
app.MapControllers();
app.UseHttpsRedirection(); 

app.Run();
