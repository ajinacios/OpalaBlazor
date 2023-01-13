using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OpalaBlazor.Web;
using OpalaBlazor.Web.Services;
using OpalaBlazor.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:3000/") });

builder.Services.AddScoped<IUsuarioService, UsuarioService>();

await builder.Build().RunAsync();
