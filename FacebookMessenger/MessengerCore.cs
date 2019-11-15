﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Tools;
using FacebookWebhook;
using FacebookWebhook.Models;
using FacebookWebhook.Security;
using Newtonsoft.Json;

namespace FacebookMessenger
{
    public class MessengerCore : ApiBase
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
        }

        public Authenticator Authenticator { get; private set; }

        public SendApi SendApi { get; private set; }

        public UserProfileApi UserProfileApi { get; private set; }

        public MessengerProfileAPI MessengerProfileAPI { get; private set; }

        public WebhookModel ProcessWebhookRequest(string requestBody)
        {
            return JsonConvert.DeserializeObject<WebhookModel>(requestBody);
        }

        public static MessengerCore CreateInstance(Credentials credentials = null)
        {
            return new MessengerCore(credentials);
        }
    }
}
