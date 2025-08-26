using CustomIdentityWithJwt.Context;
using CustomIdentityWithJwt.Managers;
using CustomIdentityWithJwt.Repositories;
using CustomIdentityWithJwt.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// TODO:
builder.Services.AddSwaggerGen(options =>
{
var jwtSecurityScheme = new OpenApiSecurityScheme
{
    Scheme = "Bearer",
    BearerFormat = "Jwt",
    Name = "Jwt Authentication",
    In = ParameterLocation.Header,
    Type = SecuritySchemeType.Http,
    Description = "Put **_ONLY-** your JWT Bearer Token on Texbox below!",

    Reference = new OpenApiReference
    {
        Id = JwtBearerDefaults.AuthenticationScheme,
        Type = ReferenceType.SecurityScheme,
    }
};
    options.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {

        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"], // appsettingsteki değer.
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidateLifetime = true,

        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"]!))

    };


});








var cs = builder.Configuration.GetConnectionString("DefaultConection");
builder.Services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer(cs));


builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserServiceV2, UserManagerV2>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
