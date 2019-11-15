using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookWebhook.Models
{
    public abstract class WebhookBaseEntry
    {
        [JsonProperty("id")]
        public virtual string ID { get; set; }

        [JsonProperty("time")]
        public virtual long Time { get; set; }
    }
}
