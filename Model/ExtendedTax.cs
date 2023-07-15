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
    /// VAT tax settings. Available settings can be found under &lt;a href&#x3D;\&quot;#operation/getTaxSettingsForCategory\&quot; target&#x3D;\&quot;_blank\&quot;&gt;\&quot;get all tax settings for category\&quot; resource&lt;/a&gt;. This field is deprecated in favor of taxSettings.
    /// </summary>
    [DataContract]
    public class ExtendedTax
    {
        /// <summary>
        /// A unique identifier of an immutable VAT setting consisting of rate, subject and exemption.
        /// </summary>
        /// <value>A unique identifier of an immutable VAT setting consisting of rate, subject and exemption.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The tax rate.
        /// </summary>
        /// <value>The tax rate.</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rate")]
        public string Rate { get; set; }

        /// <summary>
        /// The subject of taxation.
        /// </summary>
        /// <value>The subject of taxation.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// The exemption of taxation.
        /// </summary>
        /// <value>The exemption of taxation.</value>
        [DataMember(Name = "exemption", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "exemption")]
        public string Exemption { get; set; }

        /// <summary>
        /// The tax rate. This field is deprecated in favor of `rate`. Format `0.00`.
        /// </summary>
        /// <value>The tax rate. This field is deprecated in favor of `rate`. Format `0.00`.</value>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "percentage")]
        public string Percentage { get; set; }

    }
}
