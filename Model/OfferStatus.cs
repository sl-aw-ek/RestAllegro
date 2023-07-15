using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace RestAllegro.Model
{
    /// <summary>
    /// The publication status of the current offer. The possible values:    
    /// - *INACTIVE* - a draft offer   
    /// - *ACTIVATING* - the offer is planned for listing or is during the process of activation   
    /// - *ACTIVE* - the offer is active   
    /// - *ENDED* - the offer was active and is now ended (for whatever reason)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OfferStatus
    {
        INACTIVE =1,
        ACTIVATING =2,
        ACTIVE =3,
        ENDED =4
    }
}
