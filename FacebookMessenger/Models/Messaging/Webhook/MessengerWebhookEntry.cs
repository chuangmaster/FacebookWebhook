using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Messaging.Webhook
{
    public class MessengerWebhookEntry : WebhookBaseEntry
    {
        [JsonProperty("messaging")]
        public List<WebhookEvent> Events { get; set; }
    }
}
