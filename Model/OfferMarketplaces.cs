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
    /// Offer marketplaces.
    /// </summary>
    [DataContract]
    public class OfferMarketplaces
    {
        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name = "base", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base")]
        public OfferMarketplaceReference Base { get; set; }

        /// <summary>
        /// Additional marketplaces, on which the offer should be listed.
        /// </summary>
        /// <value>Additional marketplaces, on which the offer should be listed.</value>
        [DataMember(Name = "additional", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additional")]
        public List<OfferMarketplaceReference> Additional { get; set; }

    }
}
