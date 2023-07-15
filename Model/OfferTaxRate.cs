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
    /// Offer tax rate for country.
    /// </summary>
    [DataContract]
    public class OfferTaxRate
    {
        /// <summary>
        /// Tax rate value.
        /// </summary>
        /// <value>Tax rate value.</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Tax rate country code.
        /// </summary>
        /// <value>Tax rate country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

    }
}
