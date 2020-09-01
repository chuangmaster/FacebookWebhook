using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class Standby
    {
        [JsonProperty("sender")]
        public Identifier Sender { get; set; }

        [JsonProperty("recipient")]
        public Identifier Recipient { get; set; }

        [JsonProperty("timestamp")]
        public virtual string TimeStamp { get; set; }

        [JsonProperty("message")]
        public TextMessage Message { get; set; }

        public class TextMessage
        {
            [JsonProperty("text")]
            public virtual string Text { get; set; }

            [JsonProperty("mid")]
            public virtual string Mid { get; set; }
        }

        public class Identifier
        {
            [JsonProperty("id")]
            public string ID { get; set; }
        }
    }
}
