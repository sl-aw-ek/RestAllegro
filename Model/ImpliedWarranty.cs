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
    /// The implied warranty information.
    /// </summary>
    [DataContract]
    public class ImpliedWarranty
    {
        /// <summary>
        /// The ID of the implied warranty definition.
        /// </summary>
        /// <value>The ID of the implied warranty definition.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

    }
}
