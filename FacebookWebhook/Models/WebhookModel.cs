using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models.Entry;
using Newtonsoft.Json;

namespace FacebookWebhook.Models
{
    public class WebhookModel<T> where T : WebhookBaseEntry
    {
        [JsonProperty("object")]
        public virtual string _Object { get; set; }

        [JsonProperty("entry")]
        public virtual List<T> Entries { get; set; }
    }
}
