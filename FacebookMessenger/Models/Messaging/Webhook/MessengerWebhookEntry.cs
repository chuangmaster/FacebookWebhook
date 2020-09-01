using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using FacebookWebhook.Models.Entry;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class MessengerWebhookEntry : WebhookBaseEntry
    {
        [JsonProperty("messaging")]
        public List<WebhookEvent> Events { get; set; }

        [JsonProperty("standby")]
        public List<Standby> Standbys { get; set; }

        [JsonIgnore] 
        public bool IsStandbys => this.Standbys.Count > 0;
    }
}
