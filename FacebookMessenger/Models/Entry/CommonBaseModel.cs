using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWebhook.Models;
using FacebookWebhook.Models.Entry;

namespace FacebookMessenger.Models.Entry
{
    public class CommonBaseModel
    {
        /// <summary>
        /// Feed Entry
        /// </summary>
        public WebhookModel<FeedEntry> Feed { get; set; }

        /// <summary>
        /// Messenger Entry
        /// </summary>
        public WebhookModel<MessengerWebhookEntry> Messenger { get; set; }
    }
}
