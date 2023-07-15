using Microsoft.SqlServer.Server;
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
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SellingModeFormat
    {
        BUY_NOW =1,
        AUCTION = 2,
        ADVERTISEMENT =3
    }
}
