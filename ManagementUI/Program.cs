using Management.ManagementUI.Services.Base;
using ManagementUI;
using ManagementUI.Contracts;
using ManagementUI.Services;
using Management.ManagementUI.Services.Base;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IClient,Client>(client => client.BaseAddress = new Uri("https://localhost:7003"));

//builder.Services.AddScoped<HttpClient>(s =>
//{
//    return new HttpClient { BaseAddress = new Uri(@"https://localhost:7003/") };
//});
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

await builder.Build().RunAsync();
