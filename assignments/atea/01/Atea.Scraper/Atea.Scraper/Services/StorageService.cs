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
    public TableServiceClient GetTableServiceClient() => _tableServiceClient;
    public BlobServiceClient GetBlobServiceClient() => _blobServiceClient;
}