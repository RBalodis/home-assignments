using Atea.Scraper.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atea.Scraper;

public class DownloadLog
{
    private readonly ILogger<DownloadLog> _logger;
    private readonly IStorageService _storageService;

    public DownloadLog(ILogger<DownloadLog> logger, IStorageService storageService)
    {
        _logger = logger;
        _storageService = storageService;
    }

    [Function("DownloadLog")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        var blobContainerClient = _storageService.GetBlobContainerClient("atea");
        Guid.TryParse(req.Query["id"], out Guid id);
        
        var blob = blobContainerClient.GetBlobClient($"{id.ToString()}.json");
        if (blob == null)
        {
            return new NotFoundResult();
        }
        _logger.LogInformation("Downloading log file");
        var content = await blob.DownloadContentAsync();
        
        _logger.LogInformation("File downloaded");
        return new OkObjectResult(content);
    }

}