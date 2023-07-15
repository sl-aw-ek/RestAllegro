using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    /// <summary>
    /// Publication duration, ISO 8601 duration format.
    /// This field must be set to one of the following:
    /// PT0S for immediately, PT24H, P2D, P3D, P4D, P5D, P7D, P10D, P14D, P21D, P30D, P60D.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OfferDuration
    {
        PT0S = 0,
        PT24H =1,
        P2D =2,
        P3D =3, 
        P4D =4, 
        P5D =5, 
        P7D =6, 
        P10D =7,
        P14D =8, 
        P21D =9, 
        P30D =10, 
        P60D = 11
    }
}
