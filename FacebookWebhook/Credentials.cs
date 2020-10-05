using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWebhook
{
    public class Credentials
    {
        public string PageToken { get; set; }
        public string AppSecret { get; set; }
        public string VerifyToken { get; set; }
        public string PageId { get; set; }
    }
}
