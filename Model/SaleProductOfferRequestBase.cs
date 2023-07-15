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
    public class SaleProductOfferRequestBase : SaleProductOffer
    {
 
        [DataMember(Name = "category", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "category")]
        public OfferCategoryRequest Category { get; set; }

        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parameters")]
        public ParameterProductOfferRequest Parameters { get; set; }

        /// <summary>
        /// Not yaml info 
        /// </summary> 
        [DataMember(Name = "publication", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publication")]
        public SaleProductOfferRequestBasePublication Publication { get; set; }

        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delivery")]
        public SaleProductOfferRequestBaseDelivery Delivery { get; set; }

        [DataMember(Name = "afterSalesServices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "afterSalesServices")]
        public AfterSalesServicesProductOfferRequest AfterSalesServices { get; set; }

        [DataMember(Name = "discounts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "discounts")]
        public DiscountsProductOfferRequest Discounts { get; set; }


        [DataMember(Name = "sizeTable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sizeTable")]
        public Object SizeTable { get; set; }

    }
}
