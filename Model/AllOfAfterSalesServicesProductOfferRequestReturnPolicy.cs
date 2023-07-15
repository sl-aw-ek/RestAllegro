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
    public class AllOfAfterSalesServicesProductOfferRequestReturnPolicy : ReturnPolicy
    {
        /// <summary>
        /// The name of the return policy definition.
        /// </summary>
        /// <value>The name of the return policy definition.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
