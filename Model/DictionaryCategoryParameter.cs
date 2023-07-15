using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    [DataContract]
    public class DictionaryCategoryParameter : CategoryParameter
    {
        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name = "restrictions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "restrictions")]
        public DictionaryCategoryProductParameterRestrictions Restrictions { get; set; }

        /// <summary>
        /// Defines the values accepted for this parameter.
        /// </summary>
        /// <value>Defines the values accepted for this parameter.</value>
        [DataMember(Name = "dictionary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dictionary")]
        public List<DictionaryCategoryParameterDictionary> Dictionary { get; set; }
    }
}
