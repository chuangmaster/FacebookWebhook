﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models.Messaging;
using FacebookMessenger.Models.Messaging.Messages;

namespace FacebookWebhook.Models
{
    public class Message
    {
        [JsonProperty("quick_replies")]
        public virtual List<QuickReply> QuickReplies { get; set; }

        [JsonProperty("metadata")]
        public virtual string Metadata { get; set; }
    }
}
