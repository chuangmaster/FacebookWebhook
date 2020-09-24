using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models;
using FacebookMessenger.Models.Entry;
using FacebookMessenger.Tools;
using FacebookWebhook.Models;
using FacebookWebhook.Models.Entry;
using FacebookWebhook.Security;
using FacebookWebhook.Tools;
using Newtonsoft.Json;

namespace FacebookMessenger
{
    public class CommonWebhookCore : ICommonWebhookCore
    {
        public Authenticator Authenticator { get; }
        public SendApi SendApi { get; }
        public UserProfileApi UserProfileApi { get; }
        public MessengerProfileAPI MessengerProfileAPI { get; }
        public HandoverProtocolHandler HandoverProtocolHandler { get; }
        public CommonBaseModel ProcessWebhookRequest(string requestBody)
        {
            var messenger = JsonConvert.DeserializeObject<MessengerWebhookEntry>(requestBody);
            var feed = JsonConvert.DeserializeObject<FeedEntry>(requestBody);

            var result = new CommonBaseModel()
            {
                Messenger = messenger,
                Feed = feed
            };

            return result;
        }
    }

    /// <summary>
    /// Core with Messenger process and feed process
    /// </summary>
    public interface ICommonWebhookCore
    {
        Authenticator Authenticator { get; }

        SendApi SendApi { get; }

        UserProfileApi UserProfileApi { get; }

        MessengerProfileAPI MessengerProfileAPI { get; }

        HandoverProtocolHandler HandoverProtocolHandler { get; }


        CommonBaseModel ProcessWebhookRequest(string requestBody);
    }
}
