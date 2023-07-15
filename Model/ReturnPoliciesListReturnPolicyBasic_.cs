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
    /// 
    /// </summary>
    [DataContract]
    public class ReturnPoliciesListReturnPolicyBasic
    {
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets ReturnPolicies
        /// </summary>
        [DataMember(Name = "returnPolicies", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnPolicies")]
        public List<ReturnPolicyBasic> ReturnPolicies { get; set; }
    }
}
