using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InstagramWebhook.Models
{
    public abstract class ChangeModel<T> 
        where T : ValueBaseModel
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("value")]
        public T Type { get; set; }
    }
}
