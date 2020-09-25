using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacebookMessenger.Models.Messaging.RecipientIdentifier
{
    public class RecipientCommentId : RecipientIdentifier
    {
        [JsonProperty("comment_id")]
        public string CommentId { get; set; }
    }
}
