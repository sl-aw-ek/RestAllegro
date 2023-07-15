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
    public class StringCategoryProductParameterRestrictions
    {
        /// <summary>
        /// The minimum length of the parameter value.
        /// </summary>
        /// <value>The minimum length of the parameter value.</value>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minLength")]
        public int? MinLength { get; set; }

        /// <summary>
        /// The maximum length of the parameter value.
        /// </summary>
        /// <value>The maximum length of the parameter value.</value>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxLength")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Indicates how many different values can be provided for this parameter.
        /// </summary>
        /// <value>Indicates how many different values can be provided for this parameter.</value>
        [DataMember(Name = "allowedNumberOfValues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allowedNumberOfValues")]
        public int? AllowedNumberOfValues { get; set; }
    }
}
