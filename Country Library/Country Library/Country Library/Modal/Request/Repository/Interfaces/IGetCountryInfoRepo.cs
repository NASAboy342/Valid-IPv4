
using CountryLibrary.Modal.Response;

namespace Country_Library.Repository.Interfaces
{
    public interface IGetCountryInfoRepo
    {
        public Task<List<CountryInfoResponses>> GetCountryByName(string name);

        public Task<List<CountryInfoResponses>> GetCountryByRegionAndTimezone(string region, string timezone);
    }
}
