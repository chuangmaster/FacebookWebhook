using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models.Entry.Changes;
using Newtonsoft.Json;

namespace FacebookWebhook.Models.Entry
{
    public class FeedEntry : WebhookBaseEntry
    {
        [JsonProperty("Changes")]
        public List<PageFeedChanges> Changes { get; set; }
    }
}
