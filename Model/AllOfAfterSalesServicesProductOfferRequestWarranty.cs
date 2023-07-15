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
    public class AllOfAfterSalesServicesProductOfferRequestWarranty : Warranty
    {
        /// <summary>
        /// The name of the warranty definition.
        /// </summary>
        /// <value>The name of the warranty definition.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
