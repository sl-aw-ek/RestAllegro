using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    [DataContract]
    public class SaleProductOfferRequestBaseDelivery : DeliveryProductOfferRequest
    {
        [DataMember(Name = "shippingRates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shippingRates")]
        public Object ShippingRates { get; set; }

    }
}
