using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestAllegro.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AdditionalMarketplacePublication
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public AdditionalMarketplacePublicationStatus Status { get; set; }

        /// <summary>
        /// The publication status of the offer on additional marketplace. The possible values:
        //  - *NOT_REQUESTED* - seller has not declared a willingness to list this offer on given marketplace
        //  - *PENDING* - seller declared a willingness to list this offer on given marketplace, but the process has not started yet; e.g.the offer is not published yet
        //  - *IN_PROGRESS* - we process the offer's qualification for given marketplace; the offer is not listed yet
        //  - *APPROVED* - the offer is approved to list on given marketplace
        //  - *REFUSED* - the offer is refused to list on given marketplace
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdditionalMarketplacePublicationStatus
        {
            NOT_REQUESTED =1,
            PENDING = 2,
            IN_PROGRESS = 3,
            APPROVED = 4,
            REFUSED =5
        }
    }
}
