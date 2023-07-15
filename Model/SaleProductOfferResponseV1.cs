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
    public class SaleProductOfferResponseV1 : SaleProductOffer
    {

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [DataMember(Name = "productSet", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productSet")]
        public ProductSet ProductSet { get; set; }

        [DataMember(Name = "category", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "category")]
        public OfferCategory Category { get; set; }

        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachments")]
        public ProductOfferAttachment Attachments { get; set; }

        [DataMember(Name = "fundraisingCampaign", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundraisingCampaign")]
        public ProductOfferFundraisingCampaignResponse FundraisingCampaign { get; set; }

        [DataMember(Name = "additionalServices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalServices")]
        public ProductOfferAdditionalServicesResponse AdditionalServices { get; set; }

        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delivery")]
        public DeliveryProductOfferResponse Delivery { get; set; }

        [DataMember(Name = "publication", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publication")]
        public SaleProductOfferPublicationResponse Publication { get; set; }

        [DataMember(Name = "additionalMarketplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalMarketplaces")]
        public AdditionalMarketplacesResponse AdditionalMarketplaces { get; set; }

        [DataMember(Name = "b2b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "b2b")]
        public B2b Bb2 { get; set; }

        [DataMember(Name = "compatibilityList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "compatibilityList")]
        public CompatibilityListProductOfferResponse CompatibilityList { get; set; }

        /// <summary>
        /// Declared base language of the offer.
        /// BCP-47 language code 
        /// example: 'pl-PL'
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [DataMember(Name = "validation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "validation")]
        public Validation Validation { get; set; }

        [DataMember(Name = "afterSalesServices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "afterSalesServices")]
        public AfterSalesServices AfterSalesServices { get; set; }

        [DataMember(Name = "discounts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "discounts")]
        public DiscountsProductOfferResponse Discounts { get; set; }

        [DataMember(Name = "stock", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stock")]
        public Stock Stock { get; set; }

        /// <summary>
        /// List of offer parameters.
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parameters")]
        public ParameterProductOfferResponse Parameters { get; set; }

        /// <summary>
        /// Identifier of contact data for sales format ADVERTISEMENT (classified ad); 
        /// retrieve it via GET /sale/offer-contacts.
        /// </summary>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contact")]
        public JustId Contact { get; set; }

        /// <summary>
        /// Creation date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// Cannot be modified.
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// Cannot be modified.
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }
}
