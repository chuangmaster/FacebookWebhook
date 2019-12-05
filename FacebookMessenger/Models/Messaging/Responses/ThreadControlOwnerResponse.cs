using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using Newtonsoft.Json;

namespace FacebookMessenger.Models
{
    public class ThreadControlOwnerResponse : WebResponse
    {
        [JsonProperty("data")]
        public List<Data> _Data { get; set; }

        public class Data
        {
            [JsonProperty("thread_owner")]
            public ThreadOwner Owenr { get; set; }

            public class ThreadOwner
            {
                [JsonProperty("app_id")]
                public string Id { get; set; }
            }
        }
    }
}
