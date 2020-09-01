using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models.Entry.Changes.Values;
using Newtonsoft.Json;

namespace FacebookWebhook.Models.Entry.Changes
{
    public class PageFeedChanges : BaseChanges<PageFeedValue>
    {
        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("post_id")]
        public string PostId { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("is_hidden")]
        public string IsHidden { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
