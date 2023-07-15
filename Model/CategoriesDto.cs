using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    /// <summary>
    /// The list of categories.
    /// </summary>
    [DataContract]
    public class CategoriesDto
    {
        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "categories")]
        public List<CategoryDto> Categories { get; set; }
    }
}
