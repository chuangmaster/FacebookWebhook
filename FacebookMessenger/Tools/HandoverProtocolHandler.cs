using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models;
using FacebookMessenger.Models.Messaging;
using FacebookMessenger.Models.Messaging.Responses;
using FacebookWebhook;
using FacebookWebhook.Models;
using FacebookWebhook.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FacebookMessenger.Tools
{
    public class HandoverProtocolHandler : ApiBase
    {

        public async Task<SendApiResponse> SendPassingThreadControlAsync(string recipientID, string secondaryID,
            string metaData = null)
        {
            var endpoint = _FacebookGraphApiUrl + $"/me/pass_thread_control?access_token={_Credentials.PageToken}";

            return await RequestHandler.PostAsync<SendApiResponse>(JObject.FromObject(new PassingThreadControlContainer()
            {
                _Recipient = new PassingThreadControlContainer.Recipient() { ID = recipientID },
                SecondaryID = secondaryID,
                MetaData = metaData
            }), endpoint);
        }

        private async Task<ThreadOwnerResponse> GetThreadOwnerAsync(string recipientID)
        {
            var endPoint = _FacebookGraphApiUrl + $"/me/thread_owner?recipient={recipientID}&access_token={_Credentials.PageToken}";
            return await RequestHandler.GetAsync<ThreadOwnerResponse>(endPoint);
        }

        private async Task<WebResponse> SendRequestThreadControl(string recipientID, string metaData = null)
        {
            var endPoint = _FacebookGraphApiUrl + $"/me/request_thread_control?access_token={_Credentials.PageToken}";
            return await RequestHandler.PostAsync<WebResponse>(JObject.FromObject(
                new RequestThreadControlContainer()
                {
                    _Recipient = new RequestThreadControlContainer.Recipient()
                    {
                        ID = recipientID
                    },
                    MetaData = metaData
                }), endPoint);
        }

    }
}
