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
    /// <summary>
    /// Information about publication in multiple marketplaces.
    /// </summary>
    [DataContract]
    public class SaleProductOfferPublicationMarketplacesRequest
    {
        /// <summary>
        /// Specifies whether an offer should be visible in the additional marketplace. This field is not mandatory. We will interpret the absence of this field as an empty array (the listing will be visible only in its base marketplace).
        /// </summary>
        /// <value>Specifies whether an offer should be visible in the additional marketplace. This field is not mandatory. We will interpret the absence of this field as an empty array (the listing will be visible only in its base marketplace).</value>
        [DataMember(Name = "additional", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additional")]
        public List<JustId> Additional { get; set; }

    }
}
