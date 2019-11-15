using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FacebookWebhook.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudienceType
    {
        all = 1,
        custom,
        none
    }
}