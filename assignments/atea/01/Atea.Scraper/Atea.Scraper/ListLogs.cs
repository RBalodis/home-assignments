using Atea.Scraper.Services;
using Azure.Data.Tables;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atea.Scraper;

public class ListLogs
{
    private readonly ILogger<ListLogs> _logger;
    private readonly IStorageService _storageService;

    public ListLogs(ILogger<ListLogs> logger, IStorageService storageService)
    {
        _logger = logger;
        _storageService = storageService;
    }

    [Function("ListLogs")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        DateTimeOffset.TryParse(req.Query["from"], out var from);
        DateTimeOffset.TryParse(req.Query["to"], out var to);

        var table = await _storageService.GetOrCreateTableClientAsync("atea");
        
        var records = table.Query<TableEntity>(item => 
            item.Timestamp!.Value >= from && item.Timestamp.Value <= to);
        

        var response = records.AsPages(null, 50);
        
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult(response);
        
    }
}