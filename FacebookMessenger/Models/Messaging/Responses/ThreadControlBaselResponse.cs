using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class ThreadControlBaselResponse<T> where T : Control
    {
        public string Sender { get; set; }

        public string Recipient { get; set; }

        public string Timestamp { get; set; }
    }

    public class Control
    {
        [JsonProperty("new_owner_app_id")]
        public string OwnerAppId { get; set; }

        [JsonProperty("metadata")]
        public string MetaData { get; set; }
    }

    public class PassThreadControl : Control
    {
        
    }
}
