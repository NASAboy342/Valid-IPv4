using Newtonsoft.Json;

namespace CountryLibrary.Modal.Response
{
    public class JsonString
    {
        [JsonProperty("name")]
        public string fdsafda { get; set; }
        public List<string> Timezones { get; set; }

    }
}
