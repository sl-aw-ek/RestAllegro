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
    /// Additional marketplace settings.
    /// </summary>
    [DataContract]
    public class OfferAdditionalMarketplace
    {
        /// <summary>
        /// Gets or Sets Publication
        /// </summary>
        [DataMember(Name = "publication", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publication")]
        public AdditionalMarketplacePublication Publication { get; set; }

        /// <summary>
        /// Gets or Sets SellingMode
        /// </summary>
        [DataMember(Name = "sellingMode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sellingMode")]
        public AdditionalMarketplaceSellingMode SellingMode { get; set; }

    }
}
