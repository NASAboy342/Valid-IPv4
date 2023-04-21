using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;

namespace CountryLibrary.Modal.Response
{
    public class CountryName
    {
        public string Common { get; set; }
        public string Official { get; set; }
    }
    
    public class CallingCode
    {
        public string Root { get; set; }
        public List<string> Suffixes { get; set; }
    }
    public class FlagUrl
    {
        public string Png { get; set; }
        public string Svg { get; set; }
        public string Alt { get; set; }
    }
    


    public class CountryInfoResponses
    {
        public CountryName Name { get; set; }

        [JsonProperty("cca2")]
        public string Alpha2Code { get; set; }

        [JsonProperty("capital")]
        public List<string> Capitals { get; set; }

        [JsonProperty("idd")]
        public CallingCode CallingCode { get; set; }

        [JsonProperty("flags")]
        public FlagUrl FlagUrl { get; set; }
        public List<string> Timezones { get; set; }

    }
}
