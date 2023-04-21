using Country_Library.Repository.Interfaces;
using Country_Library.Services.Interface;
using CountryLibrary.Modal.Response;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace CountryLibrary.Services
{
    public class CountryService : ICountryService
    {
        public IGetCountryInfoRepo _GetCountryInfoRepo;

        public CountryService(IGetCountryInfoRepo getCountryInfoRepo)
        {
            _GetCountryInfoRepo = getCountryInfoRepo;
        }

        public async Task<List<CountryInfoResponses>> GetCounrtyByRegionAndTimezone(string region, string timezone)
        {
            var json = await _GetCountryInfoRepo.GetCountryByRegionAndTimezone(region, timezone);

            return json.Where(c => c.Timezones != null && c.Timezones.Contains(timezone)).ToList();
        }
        public async Task<List<CountryInfoResponses>> GetCounrtyByName(string name)
        {
            var json = await _GetCountryInfoRepo.GetCountryByName(name);

            return json;
        }
    }
}
