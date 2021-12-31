using Blazorise;
using Blazorise.Bulma;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Nhl.Blazor.Services;

namespace Nhl.Blazor;

/// <summary>
/// The main program.
/// </summary>
public static class Program
{
    /// <summary>
    /// The main entrypoint.
    /// </summary>
    /// <param name="args">The cli arguments.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");

        builder.Services
            .AddBlazorise()
            .AddBulmaProviders();

        builder.Services.AddScoped(_ => new HttpClient
        {
            BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        });

        builder.Services.AddScoped<IStatsApiService, StatsApiService>();

        await builder.Build().RunAsync()
            .ConfigureAwait(false);
    }
}
