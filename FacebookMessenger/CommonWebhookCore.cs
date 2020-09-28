using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models;
using FacebookMessenger.Models.Entry;
using FacebookMessenger.Models.JsonConverter;
using FacebookMessenger.Tools;
using FacebookWebhook;
using FacebookWebhook.Models;
using FacebookWebhook.Models.Entry;
using FacebookWebhook.Security;
using FacebookWebhook.Tools;
using Newtonsoft.Json;

namespace FacebookMessenger
{
    public class CommonWebhookCore : ApiBase, ICommonWebhookCore
    {

        public CommonWebhookCore()
        {
            
        }
        public CommonWebhookCore(Credentials credentials) : base(credentials)
        {
            
        }

        protected override void Initialize(Credentials credentials = null)
        {
            base.Initialize(credentials);

            Authenticator = new Authenticator(credentials);
            SendApi = new SendApi(credentials);
            UserProfileApi = new UserProfileApi(credentials);
            MessengerProfileAPI = new MessengerProfileAPI(credentials);
            HandoverProtocolHandler = new HandoverProtocolHandler(credentials);
        }

        public CommonBaseModel ProcessWebhookRequest(string requestBody)
        {
            var messenger = JsonConvert.DeserializeObject<WebhookModel<MessengerWebhookEntry>>(requestBody, new JsonSerializerSettings()
            {
                Converters = new List<JsonConverter>()
                {
                    new RecipientIdentifierConverter()
                }
            });
            var feed = JsonConvert.DeserializeObject<WebhookModel<FeedEntry>>(requestBody);

            var result = new CommonBaseModel()
            {
                Messenger = messenger,
                Feed = feed
            };

            return result;
        }
        public Authenticator Authenticator { get; private set; }

        public SendApi SendApi { get; private set; }

        public UserProfileApi UserProfileApi { get; private set; }

        public MessengerProfileAPI MessengerProfileAPI { get; private set; }

        public HandoverProtocolHandler HandoverProtocolHandler { get; private set; }

        public static CommonWebhookCore CreateInstance(Credentials credentials = null)
        {
            return new CommonWebhookCore(credentials);
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
