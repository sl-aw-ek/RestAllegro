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
    public class ProductSet
    {
        [DataMember(Name = "product", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product")]
        public ProductSetElement ProductSetElement { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public ProductSetElementQuantity ProductSetElementQuantity { get; set; }
    }
}
