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
    public class CompatibilityListTextItem : CompatibilityListItem
    {
        /// <summary>
        /// Text description of the compatible item. Maximum length of the text depends on category where compatible item is used. Should be used in categories where TEXT version of compatible list is supported. See <a href=\"/documentation/#tag/Compatibility-List/paths/~1sale~1compatibility-list~1supported-categories/get\"> supported-categories</a> resource. <a href=\"../../compatibility_list\" target=\"_blank\">Read more</a>.
        /// </summary>
        /// <value>Text description of the compatible item. Maximum length of the text depends on category where compatible item is used. Should be used in categories where TEXT version of compatible list is supported. See <a href=\"/documentation/#tag/Compatibility-List/paths/~1sale~1compatibility-list~1supported-categories/get\"> supported-categories</a> resource. <a href=\"../../compatibility_list\" target=\"_blank\">Read more</a>.</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
