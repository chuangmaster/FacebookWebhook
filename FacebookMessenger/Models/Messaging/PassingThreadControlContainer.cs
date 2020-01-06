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
        public Recipient _Recipient { get; set; }

        [JsonProperty("target_app_id")]
        public string SecondaryID { get; set; }

        [JsonProperty("metadata")]
        public string MetaData { get; set; }

        public class Recipient
        {
            [JsonProperty("id")]
            public string ID { get; set; }
        }
    }
}
