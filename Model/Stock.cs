using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
    public class Stock
    {
        /// <summary>
        /// Quantity of this offer available for sale - how many times this offer can be sold.
        /// </summary>
        /// <value>Quantity of this offer available for sale - how many times this offer can be sold.</value>
        [DataMember(Name = "available", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "available")]
        public int? Available { get; set; }

        /// <summary>
        /// Stock unit
        /// </summary>
        /// <value>Stock unit</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unit")]
        public StockUnit Unit { get; set; }


        [JsonConverter(typeof(StringEnumConverter))]
        public enum StockUnit
        {
            UNIT = 0,
            PAIR =1,
            SET =2
        }
    }
}
