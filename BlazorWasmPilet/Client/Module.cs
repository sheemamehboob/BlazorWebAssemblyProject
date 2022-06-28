using BlazorWasmPilet.Client;
using BlazorWasmPilet.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

//var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddSyncfusionBlazor();
//builder.Services.AddHttpClient<IHealthCareProviderService, HealthCareProviderService>(client =>
//{
//    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
//});
////builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//await builder.Build().RunAsync();

public class Module
{

    
    public static void Main()
    {
        // this entrypoint should remain empty
    }

    //public static void Main(string[] args)
    //{
    //    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    //    builder.RootComponents.Add<App>("#app");
    //    builder.RootComponents.Add<HeadOutlet>("head::after");

    //    this.BaseAddress = builder.HostEnvironment.BaseAddress;

    //    // this entrypoint should remain empty
    //}

    public static void ConfigureServices(IServiceCollection services)
    {
        // configure dependency injection for the components in the pilet here
        // -> use this for pilet-exclusive deps here
        // -> the method is optional; you can remove it if not needed
        services.AddSyncfusionBlazor();
        services.AddTransient<IHealthCareProviderService, HealthCareProviderService>();
    }

    public static void ConfigureShared(IServiceCollection services)
    {
        // configure dependency injection for the whole application here
        // -> the method is optional; you can remove it if not needed
    }
}