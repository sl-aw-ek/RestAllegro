using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestAllegro.Model
{
    [DataContract]
    public class AllOfDeliveryProductOfferRequestShippingRates : JustId
    {
        /// <summary>
        /// The name of the shipping rate.
        /// </summary>
        /// <value>The name of the shipping rate.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
