﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class ThreadControlBaseResponse : WebResponse
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("recipient")]
        public string Recipient { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}
