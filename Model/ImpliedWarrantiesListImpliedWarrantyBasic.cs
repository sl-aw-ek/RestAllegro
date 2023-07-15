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
    /// 
    /// </summary>
    [DataContract]
    public class ImpliedWarrantiesListImpliedWarrantyBasic
    {
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets ImpliedWarranties
        /// </summary>
        [DataMember(Name = "impliedWarranties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "impliedWarranties")]
        public List<ImpliedWarrantyBasic> ImpliedWarranties { get; set; }
    }
}
