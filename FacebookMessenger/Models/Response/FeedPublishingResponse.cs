using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Response
{
    public class FeedPublishingResponse : WebResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
