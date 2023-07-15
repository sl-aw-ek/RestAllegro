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
    /// Settings for each additional marketplace.
    /// example: 
    /// {
    //    'allegro-cz':
    //    {
    //      'publication':
    //      {
    //        'status': 'APPROVED'
    //      },
    //      'sellingMode':
    //      {
    //          'price':
    //          {
    //              'amount': '639.37',
    //              'currency': 'CZK'
    //          }
    //      }
    //   }
    // }
    /// </summary>
    [DataContract]
    public class AdditionalMarketplaces : Dictionary<String, OfferAdditionalMarketplace>
    {

    }
}
