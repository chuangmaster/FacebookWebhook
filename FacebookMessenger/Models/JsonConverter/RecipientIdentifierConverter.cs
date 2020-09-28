using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessenger.Models.Messaging.RecipientIdentifier;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FacebookMessenger.Models.JsonConverter
{
    public class RecipientIdentifierConverter : Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (objectType == typeof(RecipientMessageIdentifier))
            {

                if (jo["id"] != null)
                    return jo.ToObject<RecipientMessageIdentifier>(serializer);
                else if (jo["post_id"] != null)
                    return jo.ToObject<RecipientPostIdentifier>(serializer);
                else if (jo["user_ref"] != null)
                    return jo.ToObject<RecipientPostIdentifier>(serializer);
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RecipientIdentifier);
        }
    }
}
