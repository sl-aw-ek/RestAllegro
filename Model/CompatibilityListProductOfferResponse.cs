using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace RestAllegro.Model
{
    [DataContract]
    public class CompatibilityListProductOfferResponse
    {
        /// <summary>
        /// Type of the compatibility list, two values are acceptable: `MANUAL`, `PRODUCT_BASED`. <ul> <li>`MANUAL` -  for offers not associated with product - compatibility list is created with items provided by user directly in the body of the request.</li> <li>`PRODUCT_BASED` - for offers associated with product - if compatibility list is provided in the product details (GET/sale/products/{productId}), it needs to be included in the offer in unchanged form. </li> </ul>
        /// </summary>
        /// <value>Type of the compatibility list, two values are acceptable: `MANUAL`, `PRODUCT_BASED`. <ul> <li>`MANUAL` -  for offers not associated with product - compatibility list is created with items provided by user directly in the body of the request.</li> <li>`PRODUCT_BASED` - for offers associated with product - if compatibility list is provided in the product details (GET/sale/products/{productId}), it needs to be included in the offer in unchanged form. </li> </ul></value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public CompatibilityListTypeEnum Type { get; set; }



        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompatibilityListTypeEnum
        {
            MANUAL =1,
            PRODUCT_BASED =2
        }
    }
}
