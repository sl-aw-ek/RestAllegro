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
    /// Defines message to the seller settings options.
    /// </summary>
    [DataContract]
    public class MessageToSellerSettings
    {
        /// <summary>
        /// Specify message to seller type.  * `OPTIONAL`: buyer is able to enter a message for the seller  * `HIDDEN`: there is no message box for the seller  * `REQUIRED`: buyer is forced to enter a message for the seller (limited to categories with `sellerCanRequirePurchaseComments` option)
        /// </summary>
        /// <value>Specify message to seller type.  * `OPTIONAL`: buyer is able to enter a message for the seller  * `HIDDEN`: there is no message box for the seller  * `REQUIRED`: buyer is forced to enter a message for the seller (limited to categories with `sellerCanRequirePurchaseComments` option)</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mode")]
        public MessageToSellerSettingsMode Mode { get; set; }

        /// <summary>
        /// Specify hint for REQUIRED message displayed for buyer
        /// </summary>
        /// <value>Specify hint for REQUIRED message displayed for buyer</value>
        [DataMember(Name = "hint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hint")]
        public string Hint { get; set; }


        public enum MessageToSellerSettingsMode
        {
            OPTIONAL =1,
            HIDDEN = 2,
            REQUIRED = 3
        }
    }
}
