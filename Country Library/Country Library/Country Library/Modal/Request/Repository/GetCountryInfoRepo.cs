using Country_Library.Repository.Interfaces;
using CountryLibrary.Modal.Response;
using Newtonsoft.Json;

namespace Country_Library.Modal.Request.Repository
{
    public class GetCountryInfoRepo : IGetCountryInfoRepo
    {
        public async Task<List<CountryInfoResponses>> GetCountryByName(string name)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://restcountries.com/v3.1/name/{name}");
            var content = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<CountryInfoResponses>>(content);

            return json;
        }

        public async Task<List<CountryInfoResponses>> GetCountryByRegionAndTimezone(string region, string timezone)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://restcountries.com/v3.1/region/{region}");
            var content = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<CountryInfoResponses>>(content);

            return json;
        }
    }
}
