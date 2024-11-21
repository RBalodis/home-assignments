using Refit;

namespace Atea.Scraper.Models;

public interface ICountryApi
{
    [Get("/lang/{language}")]
    Task<List<Country>> GetCountriesAsync(string language);
}