using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class PassThreadControlResponse : ThreadControlBaseResponse
    {
        [JsonProperty("pass_thread_control")]
        public Control _Control { get; set; }
        public class Control
        {
            [JsonProperty("new_owner_app_id")]
            public string OwnerAppId { get; set; }

            [JsonProperty("metadata")]
            public string MetaData { get; set; }
        }
    }
}
