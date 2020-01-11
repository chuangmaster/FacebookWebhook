using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InstagramWebhook.Models
{
    public class MentionValueModel : ValueBaseModel
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("comment_id")]
        public string CommentId { get; set; }
    }
}
