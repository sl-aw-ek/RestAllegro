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
    public class FloatCategoryProductParameterRestrictions
    {
        /// <summary>
        /// The minimum value of this parameter.
        /// </summary>
        /// <value>The minimum value of this parameter.</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "min")]
        public decimal? Min { get; set; }

        /// <summary>
        /// The maximum value of this parameter.
        /// </summary>
        /// <value>The maximum value of this parameter.</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "max")]
        public decimal? Max { get; set; }

        /// <summary>
        /// Indicates whether this is a range parameter. If this is `true`, then you have to provide two values for this parameter - `from` and `to`. Both these values have to be between the `min` and `max`.
        /// </summary>
        /// <value>Indicates whether this is a range parameter. If this is `true`, then you have to provide two values for this parameter - `from` and `to`. Both these values have to be between the `min` and `max`.</value>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "range")]
        public bool? Range { get; set; }

        /// <summary>
        /// Number of digits you can provide after a comma that can be transferred in the parameter value.
        /// </summary>
        /// <value>Number of digits you can provide after a comma that can be transferred in the parameter value.</value>
        [DataMember(Name = "precision", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "precision")]
        public int? Precision { get; set; }
    }
}
