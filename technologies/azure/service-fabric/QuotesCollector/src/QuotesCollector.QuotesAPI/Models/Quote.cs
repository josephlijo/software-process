using Newtonsoft.Json;

namespace QuotesCollector.QuotesAPI.Models
{
    public class Quote
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
