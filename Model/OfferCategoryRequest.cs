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
    /// Category in which the offer is listed for sale. You can indicate a category from the product&#x27;s &#x27;similar categories&#x27; to set the offer&#x27;s category.
    /// </summary>
    [DataContract]
    public class OfferCategoryRequest : Category
    {

    }
}
