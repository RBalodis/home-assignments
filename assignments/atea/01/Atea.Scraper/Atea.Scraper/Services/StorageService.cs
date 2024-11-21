using Azure.Data.Tables;
using Azure.Storage.Blobs;

namespace Atea.Scraper.Services;

public class StorageService : IStorageService
{
    private readonly TableServiceClient _tableServiceClient;
    private readonly BlobServiceClient _blobServiceClient;

    public StorageService()
    {
        var connectionString = "UseDevelopmentStorage=true";
        _tableServiceClient = new TableServiceClient(connectionString);
        _blobServiceClient = new BlobServiceClient(connectionString);
    }

    public async Task<TableClient> GetOrCreateTableClientAsync(string tableName)
    {
        var tableClient = _tableServiceClient.GetTableClient(tableName);
        await tableClient.CreateIfNotExistsAsync();
        return tableClient;
    }

    public BlobContainerClient GetBlobContainerClient(string containerName)
    {
        var blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        blobContainerClient.CreateIfNotExists();
        return blobContainerClient;
    }
}