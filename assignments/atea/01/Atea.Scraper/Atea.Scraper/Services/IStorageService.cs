using Azure.Data.Tables;
using Azure.Storage.Blobs;

namespace Atea.Scraper.Services;

public interface IStorageService
{
    Task<TableClient> GetOrCreateTableClientAsync(string tableName);
    BlobContainerClient GetBlobContainerClient(string containerName);
}