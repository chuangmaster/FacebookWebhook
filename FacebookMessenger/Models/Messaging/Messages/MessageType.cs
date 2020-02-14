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
    /// Refer https://developers.facebook.com/docs/messenger-platform/send-messages/#Messaging%20Types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        RESPONSE,
        UPDATE,
        MESSAGE_TAG
    }
}
