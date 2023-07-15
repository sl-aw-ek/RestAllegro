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
    public  class CategoryParameterList
    {
        /// <summary>
        /// The list of parameters supported by the category.
        /// </summary>
        /// <value>The list of parameters supported by the category.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parameters")]
        public List<CategoryParameter> Parameters { get; set; }
    }
}
