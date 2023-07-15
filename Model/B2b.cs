using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    /// <summary>
    /// Defines offer properties for buyers with company account (Allegro Biznes).
    /// </summary>
    [DataContract]
    public class B2b
    {
        /// <summary>
        /// If true, then only users with company account are eligible to buy given offer. Offers buyable only by business are allowed only in selected categories. False by default.
        /// </summary>
        /// <value>If true, then only users with company account are eligible to buy given offer. Offers buyable only by business are allowed only in selected categories. False by default.</value>
        [DataMember(Name = "buyableOnlyByBusiness", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "buyableOnlyByBusiness")]
        public bool? BuyableOnlyByBusiness { get; set; }
    }
}
