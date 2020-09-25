using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookWebhook.Models.Entry.Changes.Values
{
    public class PageFeedValue : BaseValue
    {
        [JsonProperty("from")]
        public From _From { get; set; }

        public class From
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("post_id")]
        public string PostId { get; set; }

        [JsonProperty("comment_id")]
        public string CommentId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("is_hidden")]
        public string IsHidden { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
