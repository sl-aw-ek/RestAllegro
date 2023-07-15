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
    public class DiscountsProductOfferResponse
    {
        /// <summary>
        /// Gets or Sets WholesalePriceList
        /// </summary>
        [DataMember(Name = "wholesalePriceList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wholesalePriceList")]
        public JustId WholesalePriceList { get; set; }

    }
}
