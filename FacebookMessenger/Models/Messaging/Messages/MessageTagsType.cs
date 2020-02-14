using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FacebookMessenger.Models.Messaging.Messages
{
    /// <summary>
    /// Refer https://developers.facebook.com/docs/messenger-platform/send-messages/message-tags
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageTagsType
    {
        CONFIRMED_EVENT_UPDATE,
        POST_PURCHASE_UPDATE,
        ACCOUNT_UPDATE
    }
}
