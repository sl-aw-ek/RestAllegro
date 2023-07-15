using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    [DataContract]
    public class ParameterProductOfferRequest
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the parameter.
        /// </summary>
        /// <value>The name of the parameter.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RangeValue
        /// </summary>
        [DataMember(Name = "rangeValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rangeValue")]
        public ParameterRangeValue RangeValue { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "values")]
        public List<string> Values { get; set; }

        /// <summary>
        /// Gets or Sets ValuesIds
        /// </summary>
        [DataMember(Name = "valuesIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "valuesIds")]
        public List<string> ValuesIds { get; set; }

    }
}
