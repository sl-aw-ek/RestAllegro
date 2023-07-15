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
    [JsonConverter(typeof(JsonSubTypes.JsonSubtypes), "type")]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(FloatCategoryParameter), "float")]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(IntegerCategoryParameter), "integer")]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(DictionaryCategoryParameter), "dictionary")]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(StringCategoryParameter), "string")]
    public  class CategoryParameter
    {
        /// <summary>
        /// The ID of the parameter.
        /// </summary>
        /// <value>The ID of the parameter.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the parameter in Polish.
        /// </summary>
        /// <value>The name of the parameter in Polish.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the parameter. Other fields in this structure may appear based on the type of the parameter.
        /// </summary>
        /// <value>The type of the parameter. Other fields in this structure may appear based on the type of the parameter.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Indicates whether the value of this parameter must be set in an offer. Offers without required parameters set cannot be published.
        /// </summary>
        /// <value>Indicates whether the value of this parameter must be set in an offer. Offers without required parameters set cannot be published.</value>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Indicates whether the value of this parameter must be set in a product. Product without required parameters set cannot be created.
        /// </summary>
        /// <value>Indicates whether the value of this parameter must be set in a product. Product without required parameters set cannot be created.</value>
        [DataMember(Name = "requiredForProduct", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requiredForProduct")]
        public bool? RequiredForProduct { get; set; }


        [DataMember(Name = "requiredIf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requiredIf")]
        public CategoryParameterRequirementConditions RequiredIf { get; set; }

        [DataMember(Name = "displayedIf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayedIf")]
        public CategoryParameterDisplayConditions DisplayedIf { get; set; }

        /// <summary>
        /// The unit in which values of the parameter are used. May be `null`.
        /// </summary>
        /// <value>The unit in which values of the parameter are used. May be `null`.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "options")]
        public CategoryParameterOptions Options { get; set; }
    }
}
