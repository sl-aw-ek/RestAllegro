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
    /// The definitions of the different after sales services assigned to the offer.
    /// </summary>
    [DataContract]
    public class AfterSalesServicesProductOfferRequest
    {
        /// <summary>
        /// Gets or Sets ImpliedWarranty
        /// </summary>
        [DataMember(Name = "impliedWarranty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "impliedWarranty")]
        public AllOfAfterSalesServicesProductOfferRequestImpliedWarranty ImpliedWarranty { get; set; }

        /// <summary>
        /// Gets or Sets ReturnPolicy
        /// </summary>
        [DataMember(Name = "returnPolicy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnPolicy")]
        public AllOfAfterSalesServicesProductOfferRequestReturnPolicy ReturnPolicy { get; set; }

        /// <summary>
        /// Gets or Sets Warranty
        /// </summary>
        [DataMember(Name = "warranty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "warranty")]
        public AllOfAfterSalesServicesProductOfferRequestWarranty Warranty { get; set; }

    }
}
