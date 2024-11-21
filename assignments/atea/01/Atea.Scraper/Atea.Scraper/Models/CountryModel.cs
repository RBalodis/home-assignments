using System.Text.Json.Serialization;

namespace Atea.Scraper.Models;

public class Country
{
    [JsonPropertyName("name")]
    public Name Name { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("timezones")]
    public List<string> Timezones { get; set; }
}

public class Name
{
    [JsonPropertyName("common")]
    public string Common { get; set; }
}