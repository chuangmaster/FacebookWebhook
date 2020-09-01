using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models.Entry.Changes.Values;
using Newtonsoft.Json;

namespace FacebookWebhook.Models.Entry.Changes
{
    public abstract class BaseChanges<T> where T : BaseValue
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("value")]
        public T Value { get; set; }
    }
}
