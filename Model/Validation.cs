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
    [DataContract]
    public class Validation
    {
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errors")]
        public List<ValidationError> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "warnings")]
        public List<ValidationWarning> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets ValidatedAt
        /// </summary>
        [DataMember(Name = "validatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "validatedAt")]
        public DateTime? ValidatedAt { get; set; }
    }
}
