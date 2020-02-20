using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models.Messaging.Messages;

namespace FacebookWebhook.Models
{
    public class MessageContainer
    {
        public MessageContainer()
        {
            NotificationType = NotificationType.REGULAR;
        }

        [JsonProperty("recipient")]
        public virtual Identifier Recipient { get; set; }

        [JsonProperty("notification_type")]
        public virtual NotificationType NotificationType { get; set; }

        [JsonProperty("messaging_type")]
        public virtual MessageType MessageType { get; set; }

    }

    public class MessageContainer<T> : MessageContainer where T : Message
    {
        [JsonProperty("message")]
        public virtual T Message { get; set; }

        [JsonProperty("messaging_type")]
        public override MessageType MessageType { get => MessageType.RESPONSE; }
    }

    public class TagMessageContainer<T> : MessageContainer where T : Message
    {
        [JsonProperty("message")]
        public virtual T Message { get; set; }

        [JsonProperty("tag")]
        public virtual MessageTagsType Tag { get; set; }

        [JsonProperty("messaging_type")]
        public override MessageType MessageType { get => MessageType.MESSAGE_TAG; }
    }

    public class UploadContainer : MessageContainer<AttachmentMessage>
    {
        [JsonIgnore]
        public override Identifier Recipient { get; set; }
    }
}
