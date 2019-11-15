using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWebhook.Models
{
    public class PassengerInfo
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("ticket_number")]
        public virtual string TicketNumber { get; set; }

        [JsonProperty("passenger_id")]
        public virtual string PassengerID { get; set; }
    }
}
