using CountryLibrary.Modal.Response;

namespace Country_Library.Services.Interface
{
    public interface ICountryService
    {
        public Task<List<CountryInfoResponses>> GetCounrtyByRegionAndTimezone(string region, string timezone);
        public Task<List<CountryInfoResponses>> GetCounrtyByName(string name);
    }
}
