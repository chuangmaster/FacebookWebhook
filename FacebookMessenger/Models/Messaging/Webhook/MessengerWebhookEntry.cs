﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class MessengerWebhookEntry : WebhookBaseEntry
    {
        [JsonProperty("messaging")]
        public List<WebhookEvent> Events { get; set; }

        [JsonProperty("standby")]
        public List<StandbyEvent> Standbys { get; set; }
    }
}
