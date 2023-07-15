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
    public class CompatibilityListIdItem : CompatibilityListItem
    {
        /// <summary>
        /// Id of the compatible item. Should be used in categories where ID version of compatible list is supported. 
        /// </summary>
        /// <value>Id of the compatible item. Should be used in categories where ID version of compatible list is supported. 
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Text description of the compatible item. When creating (Post) or updating (Put) a compatibility list the field is ignored.
        /// </summary>
        /// <value>Text description of the compatible item. When creating (Post) or updating (Put) a compatibility list the field is ignored.</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Details of the compatible item represented by ID.
        /// </summary>
        /// <value>Details of the compatible item represented by ID.</value>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalInfo")]
        public List<CompatibilityListIdItemAdditionalInfo> AdditionalInfo { get; set; }
    }
}
