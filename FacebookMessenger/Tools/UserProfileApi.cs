﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook;
using FacebookWebhook.Models;

namespace FacebookWebhook.Tools
{
    public class UserProfileApi : ApiBase
    {
        public UserProfileApi() : base()
        {
        }

        public UserProfileApi(Credentials credentials) : base(credentials)
        {
        }

        /// <summary>
        /// default get user profile field
        /// </summary>
        public IReadOnlyList<string> AllFields = Enum.GetNames(typeof(UserProfileField)).ToList();

        public async Task<UserProfileApiResponse> GetUserProfileAsync(string userID, List<UserProfileField> fields = null)
        {
            string queryFields = (fields == null) ? string.Join(",", AllFields) : string.Join(",", fields.Select(f => f.ToString()));
            string requestUrl = $"{_FacebookGraphApiUrl}/{userID}?fields={queryFields}&access_token={_Credentials.PageToken}";

            return await RequestHandler.GetAsync<UserProfileApiResponse>(requestUrl);
        }

        public enum UserProfileField
        {
            id,
            name,
            first_name,
            last_name,
            profile_pic,
            locale,
            timezone,
            gender,
            is_payment_enabled
        };
    }
}
