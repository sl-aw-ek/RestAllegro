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
    /// <summary>
    /// Single offer data.
    /// </summary>
    [DataContract]
    public class SaleProductOffer
    {
        /// <summary>
        /// Name (title) of an offer. Length cannot be more than 50 characters. Read more: <a href=\"../../tutorials/jak-jednym-requestem-wystawic-oferte-powiazana-z-produktem-D7Kj9gw4xFA#tytul-oferty\" target=\"_blank\">PL</a>  / <a href=\"../../tutorials/list-offer-assigned-product-one-request-D7Kj9M71Bu6#offer-title\" target=\"_blank\">EN</a> .
        /// </summary>
        /// <value>Name (title) of an offer. Length cannot be more than 50 characters. Read more: <a href=\"../../tutorials/jak-jednym-requestem-wystawic-oferte-powiazana-z-produktem-D7Kj9gw4xFA#tytul-oferty\" target=\"_blank\">PL</a>  / <a href=\"../../tutorials/list-offer-assigned-product-one-request-D7Kj9M71Bu6#offer-title\" target=\"_blank\">EN</a> .</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payments")]
        public Payments Payments { get; set; }

        /// <summary>
        /// Gets or Sets SellingMode
        /// </summary>
        [DataMember(Name = "sellingMode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sellingMode")]
        public SellingMode SellingMode { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public StandardizedDescription Description { get; set; }

        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name = "external", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "external")]
        public ExternalId External { get; set; }

        /// <summary>
        /// Gets or Sets SizeTable
        /// </summary>
        [DataMember(Name = "sizeTable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sizeTable")]
        public SizeTable SizeTable { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tax")]
        public ExtendedTax Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxSettings
        /// </summary>
        [DataMember(Name = "taxSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxSettings")]
        public OfferTaxSettings TaxSettings { get; set; }

        /// <summary>
        /// Gets or Sets MessageToSellerSettings
        /// </summary>
        [DataMember(Name = "messageToSellerSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "messageToSellerSettings")]
        public MessageToSellerSettings MessageToSellerSettings { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalMarketplaces
        /// </summary>
        [DataMember(Name = "additionalMarketplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalMarketplaces")]
        public AdditionalMarketplaces AdditionalMarketplaces { get; set; }

    }
}
