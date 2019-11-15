using Newtonsoft.Json;

namespace FacebookWebhook.Models
{
    public class Residence
    {
        [JsonProperty("city")]
        public virtual string City { get; set; }

        [JsonProperty("postal_code")]
        public virtual string PostalCode { get; set; }

        [JsonProperty("state")]
        public virtual string State { get; set; }

        [JsonProperty("country")]
        public virtual string Country { get; set; }
    }
}