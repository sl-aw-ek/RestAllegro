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
    public class SaleProductOfferPublicationBase
    {
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

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
        /// Whether to republish an offer after ending. Automatically republish offers or auctions:</br> - `BUY_NOW` offer type are republished with initial stock, regardless of how many items you have sold.</br> - `AUCTION` offer type are republished only if they were not concluded with purchase.</br> - `ADVERTISEMENT` offer type are republished until it will be finished manually.
        /// </summary>
        /// <value>Whether to republish an offer after ending. Automatically republish offers or auctions:</br> - `BUY_NOW` offer type are republished with initial stock, regardless of how many items you have sold.</br> - `AUCTION` offer type are republished only if they were not concluded with purchase.</br> - `ADVERTISEMENT` offer type are republished until it will be finished manually.</value>
        [DataMember(Name = "republish", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "republish")]
        public bool? Republish { get; set; }

    }
}
