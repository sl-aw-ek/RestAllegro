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
    public  class MeResponse
    {
        /// <summary>
        /// User Id.
        /// </summary>
        /// <value>User Id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// User login.
        /// </summary>
        /// <value>User login.</value>
        [DataMember(Name = "login", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        /// <summary>
        /// User's first name.
        /// </summary>
        /// <value>User's first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// User's last name.
        /// </summary>
        /// <value>User's last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// User's email.
        /// </summary>
        /// <value>User's email.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets BaseMarketplace
        /// </summary>
        [DataMember(Name = "baseMarketplace", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "baseMarketplace")]
        public MeResponseBaseMarketplace BaseMarketplace { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "company")]
        public Company Company { get; set; }

        /// <summary>
        /// User's features list:  - `SUPER_SELLER` - Super Seller (\"Super Sprzedawca\") information.  - `ONE_FULFILLMENT` - Seller uses the fulfillment service provided by Allegro.
        /// </summary>
        /// <value>User's features list:  - `SUPER_SELLER` - Super Seller (\"Super Sprzedawca\") information.  - `ONE_FULFILLMENT` - Seller uses the fulfillment service provided by Allegro.</value>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "features")]
        public List<string> Features { get; set; }
    }
}
