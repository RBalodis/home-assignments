using System;
using Atea.Scraper.Models;
using Atea.Scraper.Services;
using Azure;
using Azure.Data.Tables;
using Azure.Storage.Blobs;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Refit;

namespace Atea.Scraper;

public class Scraper
{
    private readonly ILogger<Scraper> _logger;
    private readonly IStorageService _storageService;

    public Scraper(ILogger<Scraper> logger, IStorageService storageService)
    {
        _logger = logger;
        _storageService = storageService;
    }
    
    //https://restcountries.com/v3.1/lang/latvian
    [Function("Scraper")]
    public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer)
    {
        var apiClient = RestService.For<ICountryApi>("https://restcountries.com/v3.1");

        var response = await apiClient.GetCountriesAsync("latvian");
        bool success = response.Count != 0;

        var table = _storageService.GetOrCreateTableClientAsync("atea");
        var key = Guid.NewGuid();
        table.Result.AddEntity(new TableEntity(success)
        {
            PartitionKey = key.ToString(),
            RowKey = key.ToString(),
        });
        
        var result = _storageService.GetBlobContainerClient("atea");
        await result.UploadBlobAsync($"{key.ToString()}.json", BinaryData.FromObjectAsJson(response));
        
        _logger.LogInformation("action performed");
    }
}