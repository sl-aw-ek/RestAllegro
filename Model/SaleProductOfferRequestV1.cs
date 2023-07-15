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
    public class SaleProductOfferRequestV1 : SaleProductOfferRequestBase
    {
        /// <summary>
        /// List of products sold in the offer.
        /// </summary>
        [DataMember(Name = "productSet", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productSet")]
        public List<ProductSet> ProductSet { get; set; }

        [DataMember(Name = "b2b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "b2b")]
        public B2b B2b { get; set; }

        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachments")]
        public ProductOfferAttachment Attachments { get; set; }

        [DataMember(Name = "fundraisingCampaign", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundraisingCampaign")]
        public ProductOfferFundraisingCampaignRequest FundraisingCampaign { get; set; }

        [DataMember(Name = "additionalServices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalServices")]
        public ProductOfferAdditionalServicesRequest AdditionalServices { get; set; }

        [DataMember(Name = "stock", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stock")]
        public SaleProductOffersRequestStock Stock { get; set; }

        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delivery")]
        public DeliveryProductOfferRequest Delivery { get; set; }

        [DataMember(Name = "publication", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publication")]
        public SaleProductOfferPublicationRequest Publication { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalMarketplaces
        /// </summary>
        [DataMember(Name = "additionalMarketplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalMarketplaces")]
        public AdditionalMarketplacesRequest AdditionalMarketplaces { get; set; }

        [DataMember(Name = "compatibilityList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "compatibilityList")]
        public CompatibilityListManualType CompatibilityList { get; set; }

        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
