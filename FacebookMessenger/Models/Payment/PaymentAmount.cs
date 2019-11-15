using Newtonsoft.Json;

namespace FacebookWebhook.Models
{
    public class PaymentAmount
    {
        [JsonProperty("currency")]
        public virtual string Currency { get; set; }

        [JsonProperty("amount")]
        public virtual string TotalAmount { get; set; }
    }
}