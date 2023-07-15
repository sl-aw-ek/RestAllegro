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
    /// The parent category data.
    /// </summary>
    [DataContract]
    public class CategoryDtoParent
    {
        /// <summary>
        /// The ID of the parent category.
        /// </summary>
        /// <value>The ID of the parent category.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
