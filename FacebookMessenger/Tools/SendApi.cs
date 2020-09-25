using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models;
using FacebookMessenger.Models.Messaging.Messages;
using FacebookMessenger.Models.Messaging.RecipientIdentifier;
using FacebookWebhook;
using FacebookWebhook.Models;

namespace FacebookWebhook.Tools
{
    public class SendApi : ApiBase
    {
        private string _SendMessageEndpoint { get; set; }
        private string _UploadAttachmentEndpoint { get; set; }

        public SendApi() : base()
        {
        }

        public SendApi(Credentials credentials) : base(credentials)
        {
        }

        protected override void Initialize(Credentials credentials = null)
        {
            base.Initialize(credentials);

            _SendMessageEndpoint = $"{_MessengerApiUrl}/messages?access_token={_Credentials.PageToken}";
            _UploadAttachmentEndpoint = $"{_MessengerApiUrl}/message_attachments?access_token={_Credentials.PageToken}";
        }

        public async Task<SendApiResponse> SendTextAsync(string recipientID, string text,
            List<QuickReply> quickReplies = null)
        {
            return await SendMessageAsync(recipientID, new TextMessage
            {
                Text = text,
                QuickReplies = quickReplies
            });
        }

        public async Task<SendApiResponse> SendTextByCommentIdAsync(string commentId, string text,
            List<QuickReply> quickReplies = null)
        {
            return await SendMessageAsync(
                new RecipientCommentId()
                {
                    CommentId = commentId
                }, new TextMessage
                {
                    Text = text,
                    QuickReplies = quickReplies
                });
        }

        public async Task<SendApiResponse> SendTextByPostIdAsync(string postId, string text,
            List<QuickReply> quickReplies = null)
        {
            return await SendMessageAsync(
                new RecipientPostIdentifier()
                {
                    PostId = postId
                }, new TextMessage
                {
                    Text = text,
                    QuickReplies = quickReplies
                });
        }

        public async Task<SendApiResponse> SendTextByUserRefAsync(string userRef, string text,
            List<QuickReply> quickReplies = null)
        {
            return await SendMessageAsync(
                new RecipientUserRef()
                {
                    UserRef = userRef
                }, new TextMessage
                {
                    Text = text,
                    QuickReplies = quickReplies
                });
        }

        /// <summary>
        /// Send Tag Message
        /// </summary>
        /// <param name="recipientID"></param>
        /// <param name="text"></param>
        /// <param name="messageTag"></param>
        /// <returns></returns>
        public async Task<SendApiResponse> SendMessageTag(string recipientID, string text, MessageTagsType messageTag)
        {
            return await SendTagMessageAsync(recipientID, new TextMessage()
            {
                Text = text
            }, messageTag);
        }

        public async Task<SendApiResponse> SendTemplateAsync<T>(string recipientID, T template,
            List<QuickReply> quickReplies = null)
            where T : TemplatePayload
        {
            return await SendMessageAsync(recipientID, new AttachmentMessage
            {
                Attachment = new Attachment<T>
                {
                    Type = AttachmentType.template,
                    Payload = template
                },
                QuickReplies = quickReplies
            });
        }

        public async Task<SendApiResponse> SendAttachmentAsync(string recipientID, Attachment attachment,
            List<QuickReply> quickReplies = null)
        {
            return await SendMessageAsync(recipientID, new AttachmentMessage
            {
                Attachment = attachment,
                QuickReplies = quickReplies
            });
        }

        public async Task<SendApiResponse> UploadAttachmentAsync(Attachment<UrlPayload> attachment)
        {
            attachment.Payload.IsReusable = true;

            return await SendAsync(JObject.FromObject(new UploadContainer
            {
                Message = new AttachmentMessage { Attachment = attachment }
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }), _UploadAttachmentEndpoint);
        }

        public async Task<SendApiResponse> SendActionAsync(string recipientID, SenderAction action)
        {
            return await SendAsync(JObject.FromObject(new SenderActionContainer
            {
                Recipient = new RecipientMessageIdentifier() { ID = recipientID },
                SenderAction = action
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendMessageAsync<T>(string recipientID, T message)
                where T : Message
        {
            return await SendAsync(JObject.FromObject(new MessageContainer<T>
            {
                Recipient = new RecipientMessageIdentifier() { ID = recipientID },
                Message = message,
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendMessageAsync<T>(RecipientMessageIdentifier recipient, T message)
            where T : Message
        {
            return await SendAsync(JObject.FromObject(new MessageContainer<T>
            {
                Recipient = recipient,
                Message = message,
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendMessageAsync<T>(RecipientCommentId recipient, T message)
            where T : Message
        {
            return await SendAsync(JObject.FromObject(new MessageContainer<T>
            {
                Recipient = recipient,
                Message = message,
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendMessageAsync<T>(RecipientUserRef recipient, T message)
            where T : Message
        {
            return await SendAsync(JObject.FromObject(new MessageContainer<T>
            {
                Recipient = recipient,
                Message = message,
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendMessageAsync<T>(RecipientPostIdentifier recipient, T message)
            where T : Message
        {
            return await SendAsync(JObject.FromObject(new MessageContainer<T>
            {
                Recipient = recipient,
                Message = message,
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendTagMessageAsync<T>(string recipientID, T message, MessageTagsType messageTag)
            where T : Message
        {
            return await SendAsync(JObject.FromObject(new TagMessageContainer<T>
            {
                Recipient = new RecipientMessageIdentifier { ID = recipientID },
                Message = message,
                Tag = messageTag,
                MessageType = MessageType.MESSAGE_TAG,
            }, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        private async Task<SendApiResponse> SendAsync(JObject json, string endPoint = null)
        {
            endPoint = endPoint ?? _SendMessageEndpoint;
            return await RequestHandler.PostAsync<SendApiResponse>(json, $"{endPoint}");
        }
    }
}