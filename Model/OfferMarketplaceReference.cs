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
    /// Marketplace identifier 
    /// </summary>
    [DataContract]
    public class OfferMarketplaceReference
    {
        /// <summary>
        /// Gets or Sets Id (example "allegro-pl")
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
