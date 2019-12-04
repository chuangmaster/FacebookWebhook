using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Messaging
{
    public class StandbyEvent
    {
        [JsonProperty("sender")]
        public Identifier Sender { get; set; }

        [JsonProperty("recipient")]
        public Identifier Recipient { get; set; }

        public class Identifier
        {
            [JsonProperty("id")]
            public string ID { get; set; }
        }
    }
}
