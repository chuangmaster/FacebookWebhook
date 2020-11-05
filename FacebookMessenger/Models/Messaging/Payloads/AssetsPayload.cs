using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Messaging.Payloads
{
    public class AssetsPayload : Payload
    {
        [JsonProperty("attachment_id")]
        public string AttachmentId { get; set; }
    }
}
