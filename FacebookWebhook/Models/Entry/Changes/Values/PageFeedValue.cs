using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookWebhook.Models.Entry.Changes.Values
{
    public class PageFeedValue : BaseValue
    {
        [JsonProperty("from")]
        public From _From { get; set; }

        public class From
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
