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
    public class DiscountsProductOfferRequestWholesalePriceList
    {
        /// <summary>
        /// Wholesale price list id
        /// </summary>
        /// <value>Wholesale price list id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the wholesale price list definition.
        /// </summary>
        /// <value>The name of the wholesale price list definition.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
