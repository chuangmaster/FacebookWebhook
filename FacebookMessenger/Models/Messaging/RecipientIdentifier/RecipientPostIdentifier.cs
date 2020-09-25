using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Messaging.RecipientIdentifier
{
    public class RecipientPostIdentifier : RecipientIdentifier
    {
        [JsonProperty("post_id")]
        public string PostId { get; set; }
    }
}
