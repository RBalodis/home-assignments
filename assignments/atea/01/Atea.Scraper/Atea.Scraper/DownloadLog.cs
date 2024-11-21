using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atea.Scraper;

public class DownloadLog
{
    private readonly ILogger<DownloadLog> _logger;

    public DownloadLog(ILogger<DownloadLog> logger)
    {
        _logger = logger;
    }

    [Function("DownloadLog")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
        
    }

}