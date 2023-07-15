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
    public  class SaleProductOfferRequestBasePublication
    {
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "duration")]
        public OfferDuration Duration { get; set; }
        //TODO: Change to dateTime !!! 
        /// <summary>
        /// Change to dateTime !!! 
        /// </summary>
        [DataMember(Name = "startingAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startingAt")]
        public OfferStartingAt StartingAt { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public OfferStatus Status { get; set; }

    }
}
