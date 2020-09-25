using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models.Messaging.Messages;
using FacebookMessenger.Models.Messaging.RecipientIdentifier;

namespace FacebookWebhook.Models
{
    public class MessageContainer
    {
        public MessageContainer()
        {
            NotificationType = NotificationType.REGULAR;
        }

        [JsonProperty("recipient")]
        public virtual RecipientIdentifier Recipient { get; set; }

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
        public override MessageType MessageType => MessageType.RESPONSE;
    }

    public class TagMessageContainer<T> : MessageContainer where T : Message
    {
        [JsonProperty("message")]
        public virtual T Message { get; set; }

        [JsonProperty("tag")]
        public virtual MessageTagsType Tag { get; set; }

        [JsonProperty("messaging_type")]
        public override MessageType MessageType => MessageType.MESSAGE_TAG;
    }

    public class UploadContainer : MessageContainer<AttachmentMessage>
    {
        [JsonIgnore]
        public override RecipientIdentifier Recipient { get; set; }
    }
}
