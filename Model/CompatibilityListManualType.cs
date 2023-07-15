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
    [DataContract]
    public class CompatibilityListManualType
    {
        /// <summary>
        /// List of the compatible items. Maximum number of elements on the list depends on type of included compatible items. Configuration and details concerning the compatible items in selected category are provided in the response for GET <a href=\"/documentation/#tag/Compatibility-List/paths/~1sale~1compatibility-list~1supported-categories/get\"> supported-categories</a> resource in `validationRules` object.
        /// </summary>
        /// <value>List of the compatible items. Maximum number of elements on the list depends on type of included compatible items. Configuration and details concerning the compatible items in selected category are provided in the response for GET <a href=\"/documentation/#tag/Compatibility-List/paths/~1sale~1compatibility-list~1supported-categories/get\"> supported-categories</a> resource in `validationRules` object.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<CompatibilityListItem> Items { get; set; }
    }
}
