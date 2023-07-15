using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    /// <summary>
    /// A list of the different options which can be used with this category.
    /// </summary>
    [DataContract]
    public class CategoryOptionsDto
    {
        /// <summary>
        /// Indicates whether offers of type ADVERTISEMENT can be listed in this category.
        /// </summary>
        /// <value>Indicates whether offers of type ADVERTISEMENT can be listed in this category.</value>
        [DataMember(Name = "advertisement", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "advertisement")]
        public bool? Advertisement { get; set; }

        /// <summary>
        /// Indicates whether advertisements listed in this category must have a price given. If the value is `true` then you don't have to provide a price when listing an advertisement in this category.
        /// </summary>
        /// <value>Indicates whether advertisements listed in this category must have a price given. If the value is `true` then you don't have to provide a price when listing an advertisement in this category.</value>
        [DataMember(Name = "advertisementPriceOptional", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "advertisementPriceOptional")]
        public bool? AdvertisementPriceOptional { get; set; }

        /// <summary>
        /// Indicates whether you can combine offers from this category into variant sets based on the color and pattern.
        /// </summary>
        /// <value>Indicates whether you can combine offers from this category into variant sets based on the color and pattern.</value>
        [DataMember(Name = "variantsByColorPatternAllowed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "variantsByColorPatternAllowed")]
        public bool? VariantsByColorPatternAllowed { get; set; }

        /// <summary>
        /// Information whether the category supports assigning offers to a product.
        /// </summary>
        /// <value>Information whether the category supports assigning offers to a product.</value>
        [DataMember(Name = "offersWithProductPublicationEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offersWithProductPublicationEnabled")]
        public bool? OffersWithProductPublicationEnabled { get; set; }

        /// <summary>
        /// Indicates whether the category supports creating products.
        /// </summary>
        /// <value>Indicates whether the category supports creating products.</value>
        [DataMember(Name = "productCreationEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productCreationEnabled")]
        public bool? ProductCreationEnabled { get; set; }

        /// <summary>
        /// Indicates whether custom parameters can be added to offers in this category.
        /// </summary>
        /// <value>Indicates whether custom parameters can be added to offers in this category.</value>
        [DataMember(Name = "customParametersEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customParametersEnabled")]
        public bool? CustomParametersEnabled { get; set; }

        /// <summary>
        /// Indicates whether the category supports message to seller in `REQUIRED` mode.
        /// </summary>
        [DataMember(Name = "sellerCanRequirePurchaseComments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sellerCanRequirePurchaseComments")]
        public bool? SellerCanRequirePurchaseComments { get; set; }



    }
}
