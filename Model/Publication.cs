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
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Publication
    {
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets EndingAt
        /// </summary>
        [DataMember(Name = "endingAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endingAt")]
        public DateTime? EndingAt { get; set; }

        /// <summary>
        /// Gets or Sets Marketplaces
        /// </summary>
        [DataMember(Name = "marketplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "marketplaces")]
        public OfferMarketplaces Marketplaces { get; set; }

        /// <summary>
        /// Gets or Sets StartingAt
        /// </summary>
        [DataMember(Name = "startingAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startingAt")]
        public DateTime? StartingAt { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public OfferStatus Status { get; set; }

        /// <summary>
        /// Indicates the reason for ending the offer:  - `USER` - offer ended by the seller.  - `ADMIN` - offer ended by an admin.  - `EXPIRATION` - offer duration had expired (valid for offers with specified duration).  - `EMPTY_STOCK` - offer ended because all available items had been sold out.  - `ERROR` - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed.
        /// </summary>
        /// <value>Indicates the reason for ending the offer:  - `USER` - offer ended by the seller.  - `ADMIN` - offer ended by an admin.  - `EXPIRATION` - offer duration had expired (valid for offers with specified duration).  - `EMPTY_STOCK` - offer ended because all available items had been sold out.  - `ERROR` - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed.</value>
        [DataMember(Name = "endedBy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endedBy")]
        public EndByEnum EndedBy { get; set; }

        /// <summary>
        /// Whether to republish an offer after ending. Automatically republish offers or auctions:</br> - `BUY_NOW` offer type are republished with initial stock, regardless of how many items you have sold.</br> - `AUCTION` offer type are republished only if they were not concluded with purchase.</br> - `ADVERTISEMENT` offer type are republished until it will be finished manually.
        /// </summary>
        /// <value>Whether to republish an offer after ending. Automatically republish offers or auctions:</br> - `BUY_NOW` offer type are republished with initial stock, regardless of how many items you have sold.</br> - `AUCTION` offer type are republished only if they were not concluded with purchase.</br> - `ADVERTISEMENT` offer type are republished until it will be finished manually.</value>
        [DataMember(Name = "republish", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "republish")]
        public bool? Republish { get; set; }


        [JsonConverter(typeof(StringEnumConverter))]
        public enum EndByEnum
        {
            USER =0,
            ADMIN =1,
            EXPIRATION =2,
            EMPTY_STOCK =3,
            ERROR = 4
        }
    }
}
