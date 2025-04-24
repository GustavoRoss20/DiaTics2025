using Business;
using DiaTics2025;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//GRR: IOC Repository
builder.Services.AddRepositoryViProduce(builder.Configuration.GetConnectionString("DiaTics2025DB") ?? "");

// GRR: IOC Business
builder.Services.AddBusiness();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
