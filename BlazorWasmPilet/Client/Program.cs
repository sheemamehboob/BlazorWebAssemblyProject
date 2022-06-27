using BlazorWasmPilet.Client;
using BlazorWasmPilet.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddHttpClient<IHealthCareProviderService, HealthCareProviderService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
