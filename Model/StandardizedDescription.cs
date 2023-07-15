using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestAllegro.Model
{
    /// <summary>
    /// The description section cannot have more than 40000 bytes in length.
    /// </summary>
    [DataContract]
    public class StandardizedDescription
    {
        /// <summary>
        /// Gets or Sets Sections
        /// </summary>
        [DataMember(Name = "sections", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sections")]
        public List<DescriptionSection> Sections { get; set; }

    }
}
