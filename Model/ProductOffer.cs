using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    [DataContract]
    public class ProductOffer : ProductOfferBase
    {
        /// <summary>
        /// Product name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [DataMember(Name = "category", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "category")]
        public ProductCategory Category { get; set; }

    }
}
