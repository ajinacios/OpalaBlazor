using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Repositories;
using OpalaBlazor.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Access to DB
string mySqlConnection = builder.Configuration.GetConnectionString("MySQLConnection");

builder.Services.AddDbContextPool<OpalaDbContext>(options =>
options.UseMySql(mySqlConnection,
ServerVersion.AutoDetect(mySqlConnection)));

//Builder.Services.AddSingleton<UsuarioService>();
//builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
//builder.Services.AddScoped<IConfigRepository, ConfigRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(policy =>
//    policy.WithOrigins("http://localhost:3010", "https://localhost:3020")
//    .AllowAnyMethod()
//    .WithHeaders(HeaderNames.ContentType)
//);

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
