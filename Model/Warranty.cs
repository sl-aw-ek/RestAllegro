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
    /// The warranty information.
    /// </summary>
    [DataContract]
    public class Warranty
    {
        /// <summary>
        /// The ID of the warranty definition.
        /// </summary>
        /// <value>The ID of the warranty definition.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

    }
}
