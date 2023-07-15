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
    /// An array of offer attachments.
    /// </summary>
    [DataContract]
    public class ProductOfferAttachment : List<ProductOfferAttachmentInner>
    {

    }
}
