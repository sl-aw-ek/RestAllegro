using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    /// <summary>
    /// A list of the different options which can be used with this parameter.
    /// </summary>
    [DataContract]
    public class CategoryParameterOptions
    {
        /// <summary>
        /// Parameters with this option enabled can be used for offer variants creation.
        /// </summary>
        /// <value>Parameters with this option enabled can be used for offer variants creation.</value>
        [DataMember(Name = "variantsAllowed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "variantsAllowed")]
        public bool? VariantsAllowed { get; set; }

        /// <summary>
        /// All offer variants must have the same values in parameters with this option enabled.
        /// </summary>
        /// <value>All offer variants must have the same values in parameters with this option enabled.</value>
        [DataMember(Name = "variantsEqual", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "variantsEqual")]
        public bool? VariantsEqual { get; set; }

        /// <summary>
        /// Indicates what value in the dictionary is defined as an ambiguous one. Only parameters with dictionaries might have this option defined.
        /// </summary>
        /// <value>Indicates what value in the dictionary is defined as an ambiguous one. Only parameters with dictionaries might have this option defined.</value>
        [DataMember(Name = "ambiguousValueId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ambiguousValueId")]
        public string AmbiguousValueId { get; set; }

        /// <summary>
        /// Indicates whether this parameter's behaviour depends on another parameter's values: - allowed values (only for dictionary parameters; see: `dictionary[].dependsOnValueIds`), - optionality (see `requiredDependsOnValueIds`, this usage is deprecated and will be replaced by   `requiredIf` in the future), - visibility (see `displayDependsOnValueIds`, this usage is deprecated and will be replaced by `displayedIf`   in the future). 
        /// </summary>
        /// <value>Indicates whether this parameter's behaviour depends on another parameter's values: - allowed values (only for dictionary parameters; see: `dictionary[].dependsOnValueIds`), - optionality (see `requiredDependsOnValueIds`, this usage is deprecated and will be replaced by   `requiredIf` in the future), - visibility (see `displayDependsOnValueIds`, this usage is deprecated and will be replaced by `displayedIf`   in the future). </value>
        [DataMember(Name = "dependsOnParameterId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dependsOnParameterId")]
        public string DependsOnParameterId { get; set; }

        /// <summary>
        /// Indicates whether this parameter's optionality depends on another parameter's values.  This parameter is required if `require` is `true` and either: - this field is `null` **or** - the parameter that this parameter depends on (see: `dependsOnParameterId`) has set any value ID from this array.  Otherwise this parameter is optional.  This field is deprecated and will be removed in the future. Please use `requiredIf` instead. 
        /// </summary>
        /// <value>Indicates whether this parameter's optionality depends on another parameter's values.  This parameter is required if `require` is `true` and either: - this field is `null` **or** - the parameter that this parameter depends on (see: `dependsOnParameterId`) has set any value ID from this array.  Otherwise this parameter is optional.  This field is deprecated and will be removed in the future. Please use `requiredIf` instead. </value>
        [DataMember(Name = "requiredDependsOnValueIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requiredDependsOnValueIds")]
        public List<string> RequiredDependsOnValueIds { get; set; }

        /// <summary>
        /// Indicates whether this parameter's visibility depends on another parameter's values.  This parameter is visible if and only if: - this field is `null` **or** - the parameter that this parameter depends on (see: `dependsOnParameterId`) has set any value ID from this array.  Otherwise this parameter will not be displayed anywhere. Setting a value of a hidden parameter is permitted, nonetheless.  This field is deprecated and will be removed in the future. Please use `displayedIf` instead. 
        /// </summary>
        /// <value>Indicates whether this parameter's visibility depends on another parameter's values.  This parameter is visible if and only if: - this field is `null` **or** - the parameter that this parameter depends on (see: `dependsOnParameterId`) has set any value ID from this array.  Otherwise this parameter will not be displayed anywhere. Setting a value of a hidden parameter is permitted, nonetheless.  This field is deprecated and will be removed in the future. Please use `displayedIf` instead. </value>
        [DataMember(Name = "displayDependsOnValueIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayDependsOnValueIds")]
        public List<string> DisplayDependsOnValueIds { get; set; }

        /// <summary>
        /// Indicates if parameter is used to define products.
        /// </summary>
        /// <value>Indicates if parameter is used to define products.</value>
        [DataMember(Name = "describesProduct", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "describesProduct")]
        public bool? DescribesProduct { get; set; }

        /// <summary>
        /// Indicates if a custom value can be added to a parameter with an ambiguous value.
        /// </summary>
        /// <value>Indicates if a custom value can be added to a parameter with an ambiguous value.</value>
        [DataMember(Name = "customValuesEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customValuesEnabled")]
        public bool? CustomValuesEnabled { get; set; }
    }
}
