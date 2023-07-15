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
    public  class DictionaryCategoryParameterDictionary
    {
        /// <summary>
        /// The ID of the dictionary value. Use it to set the value in an offer or in a product.
        /// </summary>
        /// <value>The ID of the dictionary value. Use it to set the value in an offer or in a product.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The label of the dictionary value in Polish.
        /// </summary>
        /// <value>The label of the dictionary value in Polish.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets DependsOnValueIds
        /// </summary>
        [DataMember(Name = "dependsOnValueIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dependsOnValueIds")]
        public List<string> DependsOnValueIds { get; set; }
    }
}
