using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class RequestThreadControlContainer
    {
        [JsonProperty("recipient")]
        public RequestThreadControlContainer.Recipient _Recipient { get; set; }

        [JsonProperty("metadata")]
        public string MetaData { get; set; }

        public class Recipient
        {
            [JsonProperty("id")]
            public string ID { get; set; }
        }
    }
}
