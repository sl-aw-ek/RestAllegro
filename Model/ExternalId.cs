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
    /// The information on the offer in an external system.
    /// </summary>
    [DataContract]
    public class ExternalId
    {
        /// <summary>
        /// The ID of the offer in the external system.
        /// </summary>
        /// <value>The ID of the offer in the external system.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
