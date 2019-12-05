using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FacebookMessenger.Models
{
    public class PassingThreadControlContainer
    {
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("target_app_ids")]
        public string SecondaryID { get; set; }

        [JsonProperty("metadata")]
        public string MetaData { get; set; }
    }
}
