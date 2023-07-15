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
    public  class CategoryParameterWithValue
    {
        /// <summary>
        /// Id of another parameter with a value dictionary.
        /// </summary>
        /// <value>Id of another parameter with a value dictionary.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// A list of value ids. One of them must be chosen in order to fulfill this condition. Not empty.
        /// </summary>
        /// <value>A list of value ids. One of them must be chosen in order to fulfill this condition. Not empty.</value>
        [DataMember(Name = "oneOfValueIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "oneOfValueIds")]
        public List<string> OneOfValueIds { get; set; }
    }
}
