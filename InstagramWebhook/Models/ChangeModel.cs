using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InstagramWebhook.Models
{
    public class ChangeModel<T>
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("value")]
        public T Type { get; set; }
    }
    //public abstract class ChangeBaseModel
    //{
    //    [JsonProperty("field")]
    //    public string Field { get; set; }
    //}
}
