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
    public class SaleProductOfferPublicationResponse : SaleProductOfferPublicationBase
    {
        /// <summary>
        /// Gets or Sets Marketplaces
        /// </summary>
        [DataMember(Name = "marketplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "marketplaces")]
        public SaleProductOfferPublicationMarketplacesResponse Marketplaces { get; set; }

    }
}
