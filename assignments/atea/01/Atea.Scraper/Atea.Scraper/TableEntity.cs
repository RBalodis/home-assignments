using System.Text.Json.Serialization;
using Azure;
using Azure.Data.Tables;

namespace Atea.Scraper;

public class TableEntity : ITableEntity
{
    public TableEntity()
    {
        
    }
    public TableEntity(bool success)
    {
        Success = success;
    }
    [JsonPropertyName("FileName")]
    public required string PartitionKey { get; set; }
    public required string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
    public bool Success { get; set; }
}