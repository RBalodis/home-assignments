using Azure.Data.Tables;
using Azure.Storage.Blobs;

namespace Atea.Scraper.Services;

public interface IStorageService
{
    TableServiceClient GetTableServiceClient();
    BlobServiceClient GetBlobServiceClient();
}