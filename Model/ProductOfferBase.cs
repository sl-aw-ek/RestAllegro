using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
    public class ProductOfferBase
    {
        /// <summary>
        /// Product id.
        /// </summary>
        /// <value>Product id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Type of id. This field is optional. It helps in finding products more accurately. If an idType is not set, a given id is understood as a product's id.  - `GTIN` - restricts the search filtering to GTINs (Global Trade Item Number), e.g. EAN, ISBN, UPC.  - `MPN` - restricts the search filtering to MPNs (Manufacturer Part Number).
        /// </summary>
        /// <value>Type of id. This field is optional. It helps in finding products more accurately. If an idType is not set, a given id is understood as a product's id.  - `GTIN` - restricts the search filtering to GTINs (Global Trade Item Number), e.g. EAN, ISBN, UPC.  - `MPN` - restricts the search filtering to MPNs (Manufacturer Part Number).</value>
        [DataMember(Name = "idType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "idType")]
        public IdTypeEnum IdType { get; set; }

        /// <summary>
        /// List of product parameters.
        /// </summary>
        /// <value>List of product parameters.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parameters")]
        public List<ParameterProductOfferRequest> Parameters { get; set; }

        /// <summary>
        /// List of product images.
        /// </summary>
        /// <value>List of product images.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "images")]
        public List<string> Images { get; set; }



        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdTypeEnum
        {
            GTIN = 1,
            MPN = 2
        }
    }
}
