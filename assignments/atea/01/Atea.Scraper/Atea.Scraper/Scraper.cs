using System;
using Atea.Scraper.Models;
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

    public Scraper(ILogger<Scraper> logger)
    {
        _logger = logger;
    }
    
    //https://restcountries.com/v3.1/lang/latvian
    [Function("Scraper")]
    public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer)
    {
        var apiClient = RestService.For<ICountryApi>("https://restcountries.com/v3.1");

        var response = await apiClient.GetCountriesAsync("latvian");
        bool success = response.Count != 0;

        var tableServiceClient = new TableServiceClient("UseDevelopmentStorage=true");
        await tableServiceClient.CreateTableIfNotExistsAsync("atea");
        var tableClient = tableServiceClient.GetTableClient("atea");
        var key = Guid.NewGuid();
        tableClient.AddEntity(new TableEntity(success)
        {
            PartitionKey = key.ToString(),
            RowKey = key.ToString(),
        });
        
        var blobServiceClient = new BlobServiceClient("UseDevelopmentStorage=true");
        var result =  blobServiceClient.GetBlobContainerClient("atea");
        
        await result.CreateIfNotExistsAsync();
        await result.UploadBlobAsync($"{key.ToString()}.json", BinaryData.FromObjectAsJson(response));
        
        _logger.LogInformation("action performed");
    }
}