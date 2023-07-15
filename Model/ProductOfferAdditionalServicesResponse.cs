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
    public class ProductOfferAdditionalServicesResponse
    {
        /// <summary>
        /// Id of additional services.
        /// </summary>
        /// <value>Id of additional services.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
