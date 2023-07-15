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
    /// Tax settings for offer. Available settings can be found under &lt;a href&#x3D;\&quot;#operation/getTaxSettingsForCategory\&quot; target&#x3D;\&quot;_blank\&quot;&gt;\&quot;get all tax settings for category\&quot; resource&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public class OfferTaxSettings
    {
        /// <summary>
        /// Tax rates for offer.
        /// </summary>
        /// <value>Tax rates for offer.</value>
        [DataMember(Name = "rates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rates")]
        public List<OfferTaxRate> Rates { get; set; }

        /// <summary>
        /// The subject of taxation for offer.
        /// </summary>
        /// <value>The subject of taxation for offer.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// The exemption of taxation for offer.
        /// </summary>
        /// <value>The exemption of taxation for offer.</value>
        [DataMember(Name = "exemption", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "exemption")]
        public string Exemption { get; set; }

    }
}
