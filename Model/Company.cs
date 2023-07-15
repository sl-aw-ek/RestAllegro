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
    public  class Company
    {
        /// <summary>
        /// User's company name.
        /// </summary>
        /// <value>User's company name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// User's tax identification number.
        /// </summary>
        /// <value>User's tax identification number.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxId")]
        public string TaxId { get; set; }
    }
}
