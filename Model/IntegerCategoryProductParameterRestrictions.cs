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
    /// The restrictions on values of this parameter.
    /// </summary>
    [DataContract]
    public  class IntegerCategoryProductParameterRestrictions
    {
        /// <summary>
        /// The minimum value of this parameter.
        /// </summary>
        /// <value>The minimum value of this parameter.</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "min")]
        public int? Min { get; set; }

        /// <summary>
        /// The maximum value of this parameter.
        /// </summary>
        /// <value>The maximum value of this parameter.</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "max")]
        public int? Max { get; set; }

        /// <summary>
        /// Indicates whether this is a range parameter. If this is `true`, then you have to provide two values for this parameter - `from` and `to`. Both these values have to be between the `min` and `max`.
        /// </summary>
        /// <value>Indicates whether this is a range parameter. If this is `true`, then you have to provide two values for this parameter - `from` and `to`. Both these values have to be between the `min` and `max`.</value>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "range")]
        public bool? Range { get; set; }
    }
}
