using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Properties;

namespace FacebookWebhook
{
    public class ApiBase
    {
        protected virtual string _FacebookGraphApiUrl { get; set; }
        protected virtual string _MessengerApiUrl { get; set; }
        protected virtual Credentials _Credentials { get; set; }

        public ApiBase()
        {
            Initialize();
        }

        public ApiBase(Credentials credentials)
        {
            Initialize(credentials);
        }

        protected virtual void Initialize(Credentials credentials = null)
        {
            _FacebookGraphApiUrl = "https://graph.facebook.com/v2.6";
            _MessengerApiUrl = $"{_FacebookGraphApiUrl}/me";

            if (credentials == null)
            {
                _Credentials = CreateCredentials
                (
                    Settings.Default.AppSecret,
                    Settings.Default.PageToken,
                    Settings.Default.VerifyToken
                );
            }
            else
                _Credentials = credentials;
        }

        public static Credentials CreateCredentials(string appSecret, string pageToken, string verifyToken)
        {
            return new Credentials
            {
                AppSecret = appSecret,
                PageToken = pageToken,
                VerifyToken = verifyToken
            };
        }
    }
}
