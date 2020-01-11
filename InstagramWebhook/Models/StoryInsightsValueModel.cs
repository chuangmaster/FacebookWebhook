using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace InstagramWebhook.Models
{
    public class StoryInsightsValueModel : ValueBaseModel
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("impressions")]
        public string Impressions { get; set; }

        [JsonProperty("reach")]
        public string Reach { get; set; }

        [JsonProperty("taps_forward")]
        public string TapsForward { get; set; }

        [JsonProperty("taps_back")]
        public string TapsBack { get; set; }

        [JsonProperty("exits")]
        public string Exits { get; set; }

        [JsonProperty("replies")]
        public string Replies { get; set; }
    }
}
