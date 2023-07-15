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
    /// Information on the offer&#x27;s selling mode.
    /// </summary>
    [DataContract]
    public class SellingMode
    {
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "format")]
        public SellingModeFormat Format { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        public BuyNowPrice Price { get; set; }

        /// <summary>
        /// Gets or Sets MinimalPrice
        /// </summary>
        [DataMember(Name = "minimalPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimalPrice")]
        public MinimalPrice MinimalPrice { get; set; }

        /// <summary>
        /// Gets or Sets StartingPrice
        /// </summary>
        [DataMember(Name = "startingPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startingPrice")]
        public StartingPrice StartingPrice { get; set; }

    }
}
