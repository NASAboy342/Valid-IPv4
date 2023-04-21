using Country_Library.Services.Interface;
using CountryLibrary.Modal.Request;
using CountryLibrary.Modal.Response;
using CountryLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using System.Xml.Linq;

namespace CountryLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryFilter;

        public CountryController(ICountryService countryFilter)
        {
            _countryFilter = countryFilter;
        }

        [HttpPost(nameof(GetCountryByName))]
        public async Task<List<CountryInfoResponses>> GetCountryByName(string name)
        {

            var filteredCountries = await _countryFilter.GetCounrtyByName(name);

            return filteredCountries;
        }

        [HttpPost(nameof(GetCountryByArea))]
        public async Task<List<CountryInfoResponses>> GetCountryByArea(string region, string timezone)
        {

            var filteredCountries = await _countryFilter.GetCounrtyByRegionAndTimezone(region, timezone);

            return filteredCountries;
        }
    }
}