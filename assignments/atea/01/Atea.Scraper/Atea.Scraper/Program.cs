using Atea.Scraper.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication(builder =>
    {
        // Configure options, middleware, etc., if needed
    })
    .ConfigureServices(services =>
    {
        // Register your services here
        services.AddSingleton<IStorageService, StorageService>();
    })
    .Build();

host.Run();