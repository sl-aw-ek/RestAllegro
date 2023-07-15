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
    public class SaleProductOffersRequestStock
    {
        /// <summary>
        /// Quantity of this offer available for sale - how many times this offer can be sold. Setting to 0 is possible only for offers in 'ENDED' status.
        /// </summary>
        /// <value>Quantity of this offer available for sale - how many times this offer can be sold. Setting to 0 is possible only for offers in 'ENDED' status.</value>
        [DataMember(Name = "available", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "available")]
        public int? Available { get; set; }

        /// <summary>
        /// Stock unit
        /// </summary>
        /// <value>Stock unit</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

    }
}
