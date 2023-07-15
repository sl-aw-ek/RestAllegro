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
    public class ProductSetElement
    {
        /// <summary>
        /// You should enter the product identifier (UUID or EAN) or a complete product definition.
        /// </summary>
        /// <value>You should enter the product identifier (UUID or EAN) or a complete product definition.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product")]
        public AllOfProductSetElementProduct Product { get; set; }

    }
}
