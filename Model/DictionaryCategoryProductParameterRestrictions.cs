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
    public  class DictionaryCategoryProductParameterRestrictions
    {
        /// <summary>
        /// Indicates whether this parameter can have more than one value.
        /// </summary>
        /// <value>Indicates whether this parameter can have more than one value.</value>
        [DataMember(Name = "multipleChoices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "multipleChoices")]
        public bool? MultipleChoices { get; set; }
    }
}
