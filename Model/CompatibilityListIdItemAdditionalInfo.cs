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
    public class CompatibilityListIdItemAdditionalInfo
    {
        /// <summary>
        /// Additional information describing the compatible item. E.g. for cars it can be an engine code or an equipment version.
        /// </summary>
        /// <value>Additional information describing the compatible item. E.g. for cars it can be an engine code or an equipment version.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
