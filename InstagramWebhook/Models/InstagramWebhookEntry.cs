using FacebookWebhook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramWebhook.Models;

namespace InstagramWebhook
{
    public class InstagramWebhookEntry<T> : WebhookBaseEntry 
        where T : ValueBaseModel
    {
        [JsonProperty("changes")]
        public List<ChangeModel<T>> Changes { get; set; }
    }
}
