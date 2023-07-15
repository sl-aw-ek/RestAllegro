﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    /// <summary>
    /// Restricts the circumstances when this parameter is required. &#x60;null&#x60; if solely the &#x60;required&#x60; flag determines if this parameter is required. Present if this parameter is required only if all of the contained conditions of all condition types are fulfilled. At least one condition is contained if this field is present.
    /// </summary>
    [DataContract]
    public  class CategoryParameterRequirementConditions
    {
        /// <summary>
        /// Condition type which requires this parameter only if the given other parameter has filled in one of the given value ids in an offer or product. Empty if no condition of this type is present.
        /// </summary>
        /// <value>Condition type which requires this parameter only if the given other parameter has filled in one of the given value ids in an offer or product. Empty if no condition of this type is present.</value>
        [DataMember(Name = "parametersWithValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parametersWithValue")]
        public List<CategoryParameterWithValue> ParametersWithValue { get; set; }

        /// <summary>
        /// Condition type which requires this parameter only if the given other parameter has filled neither a value nor a value id in an offer or product. Empty if no condition of this type is present.
        /// </summary>
        /// <value>Condition type which requires this parameter only if the given other parameter has filled neither a value nor a value id in an offer or product. Empty if no condition of this type is present.</value>
        [DataMember(Name = "parametersWithoutValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parametersWithoutValue")]
        public List<CategoryParameterWithoutValue> ParametersWithoutValue { get; set; }
    }
}
