using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//TODO: ShipmentDate - nie ma w YAML - https://github.com/allegro/allegro-api/issues/7078
namespace RestAllegro.Model
{
    [DataContract]
    public class DeliveryProductOfferRequest
    {
        /// <summary>
        /// Handling time, ISO 8601 duration format. This field must be set to one of the following: PT0S for immediately, PT24H, P2D, P3D, P4D, P5D, P7D, P10D, P14D, P21D, P30D, P60D.
        /// </summary>
        /// <value>Handling time, ISO 8601 duration format. This field must be set to one of the following: PT0S for immediately, PT24H, P2D, P3D, P4D, P5D, P7D, P10D, P14D, P21D, P30D, P60D.</value>
        [DataMember(Name = "handlingTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "handlingTime")]
        public string HandlingTime { get; set; }

        /// <summary>
        /// Gets or Sets ShippingRates
        /// </summary>
        [DataMember(Name = "shippingRates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shippingRates")]
        public AllOfDeliveryProductOfferRequestShippingRates ShippingRates { get; set; }

        /// <summary>
        /// Additional information about delivery. Parameter is deprecated and will be removed in the future. Additional information is only visible on marketplace `allegro-pl`.
        /// </summary>
        /// <value>Additional information about delivery. Parameter is deprecated and will be removed in the future. Additional information is only visible on marketplace `allegro-pl`.</value>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalInfo")]
        public string AdditionalInfo { get; set; }


        /// <summary>
        /// Shipment date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        [DataMember(Name = "shipmentDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shipmentDate")]
        public DateTime? ShipmentDate { get; set; }
    }
}
