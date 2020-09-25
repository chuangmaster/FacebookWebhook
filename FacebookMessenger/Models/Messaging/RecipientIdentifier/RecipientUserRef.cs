using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Messaging.RecipientIdentifier
{
    public class RecipientUserRef : RecipientIdentifier
    {
        [JsonProperty("user_ref")]
        public string UserRef { get; set; }
    }
}
