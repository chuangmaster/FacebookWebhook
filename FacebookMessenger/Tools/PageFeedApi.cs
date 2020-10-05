using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models.Response;
using Newtonsoft.Json.Linq;

namespace FacebookWebhook.Tools
{
    /// <summary>
    /// refs https://developers.facebook.com/docs/pages/publishing/
    /// </summary>
    public class PageFeedAPI : ApiBase
    {

        public PageFeedAPI() : base()
        {

        }

        public PageFeedAPI(Credentials credentials) : base(credentials)
        {

        }

        public async Task<CommentOnThePostResponse> CommentOnThePost(string pagePostId, string text)
        {
            return await CommentAsync($"{_FacebookGraphApiUrl}/{pagePostId}/comments?message={text}&access_token={_Credentials.PageToken}");
        }


        public async Task<FeedPublishingResponse> PublishPostAsync(string text)
        {
            return await PublishAsync($"{_FacebookGraphApiUrl}/{_Credentials.PageId}/feed?message={text}&access_token={_Credentials.PageToken}");
        }


        private async Task<FeedPublishingResponse> PublishAsync(string endPoint = null)
        {
            endPoint = endPoint ?? $"{_FacebookGraphApiUrl}/{_Credentials.PageId}/feed";

            return await RequestHandler.PostAsync<FeedPublishingResponse>(JObject.FromObject(new { }), endPoint);
        }

        private async Task<CommentOnThePostResponse> CommentAsync(string endPoint = null)
        {
            endPoint = endPoint ?? $"{_FacebookGraphApiUrl}/{_Credentials.PageId}/comments";

            return await RequestHandler.PostAsync<CommentOnThePostResponse>(JObject.FromObject(new { }), endPoint);
        }
    }
}
