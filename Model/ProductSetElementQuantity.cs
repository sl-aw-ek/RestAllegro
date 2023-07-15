using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace RestAllegro.Model
{
    [DataContract]
    public class ProductSetElementQuantity
    {
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public ProductSetElementQuantityQuantity Quantity { get; set; }
    }
}
