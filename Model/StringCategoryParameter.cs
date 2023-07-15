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
    public  class StringCategoryParameter : CategoryParameter
    {
        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name = "restrictions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "restrictions")]
        public StringCategoryProductParameterRestrictions Restrictions { get; set; }
    }
}
