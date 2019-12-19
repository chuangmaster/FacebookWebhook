using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models;
using FacebookMessenger.Tools;
using FacebookWebhook.Tools;
using FacebookWebhook;
using FacebookWebhook.Models;
using FacebookWebhook.Security;
using Newtonsoft.Json;

namespace FacebookMessenger
{
    public class MessengerCore : ApiBase, IMessengerCore
    {
        public MessengerCore() : base()
        {
        }

        public MessengerCore(Credentials credentials) : base(credentials)
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

        public Authenticator Authenticator { get; private set; }

        public SendApi SendApi { get; private set; }

        public UserProfileApi UserProfileApi { get; private set; }

        public MessengerProfileAPI MessengerProfileAPI { get; private set; }

        public HandoverProtocolHandler HandoverProtocolHandler { get; private set; }

        public WebhookModel<MessengerWebhookEntry> ProcessWebhookRequest(string requestBody)
        {
            return JsonConvert.DeserializeObject<WebhookModel<MessengerWebhookEntry>>(requestBody);
        }

        public static MessengerCore CreateInstance(Credentials credentials = null)
        {
            return new MessengerCore(credentials);
        }
    }


    public interface IMessengerCore
    {
        Authenticator Authenticator { get; }

        SendApi SendApi { get; }

        UserProfileApi UserProfileApi { get; }

        MessengerProfileAPI MessengerProfileAPI { get; }

        HandoverProtocolHandler HandoverProtocolHandler { get; }

        WebhookModel<MessengerWebhookEntry> ProcessWebhookRequest(string requestBody);
    }
}
