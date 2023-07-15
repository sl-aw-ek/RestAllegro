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
    public class SaleProductOfferPublicationMarketplacesResponse
    {
        /// <summary>
        /// Specifies whether an offer is visible in the additional marketplace.
        /// </summary>
        /// <value>Specifies whether an offer is visible in the additional marketplace.</value>
        [DataMember(Name = "additional", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additional")]
        public List<JustId> Additional { get; set; }

        /// <summary>
        /// <small>[read-only]</small> Specifies the offer’s base service. We assign the value in the field automatically when the offer is created and it is read-only, it will never change.
        /// </summary>
        /// <value><small>[read-only]</small> Specifies the offer’s base service. We assign the value in the field automatically when the offer is created and it is read-only, it will never change.</value>
        [DataMember(Name = "base", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base")]
        public JustId Base { get; set; }
    }
}
