﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWebhook.Models
{
    public class RefParam
    {
        [JsonProperty("ref")]
        public virtual string Ref { get; set; }
    }
}