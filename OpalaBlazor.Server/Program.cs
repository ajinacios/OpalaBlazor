using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using OpalaBlazor.Server.Authentication;
using OpalaBlazor.Server.Services;
using OpalaBlazor.Server.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

builder.Services.AddSingleton<UsuarioService>();
builder.Services.AddHttpClient<IUsuarioService, UsuarioService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:3000");
});
builder.Services.AddSingleton<InspecaoService>();
builder.Services.AddHttpClient<IInspecaoService, InspecaoService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:3000");
});
builder.Services.AddSingleton<PessoaJurService>();
builder.Services.AddHttpClient<IPessoaJurService, PessoaJurService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:3000");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
