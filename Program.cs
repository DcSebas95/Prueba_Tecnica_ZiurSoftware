using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ZiurBlazorTest;
//llamado de servicio   
using ZiurBlazorTest.Services;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Contrucion del servicio
builder.Services.AddScoped<ControlfinancieroService>();



await builder.Build().RunAsync();
