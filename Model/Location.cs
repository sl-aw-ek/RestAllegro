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
    /// <summary>
    /// for offer with a delivery method it is a parcel dispatch location. For offers with personal pick-up it is a pick-up location, additionally we recommend to use points of service 
    /// </summary>
    [DataContract]
    public class Location
    {
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// The 2-letter country code as defined in ISO 3166.
        /// </summary>
        /// <value>The 2-letter country code as defined in ISO 3166.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The format of post code depends on 'countryCode'. For countryCode equal to 'PL', the expected format is 'XX-XXX', for other countries format is less restrictive - 12 characters or less are expected.
        /// </summary>
        /// <value>The format of post code depends on 'countryCode'. For countryCode equal to 'PL', the expected format is 'XX-XXX', for other countries format is less restrictive - 12 characters or less are expected.</value>
        [DataMember(Name = "postCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// This field is mandatory if countryCode is set to \"PL\", for other values, currently, it is ignored. For countryCode equalling \"PL\", this field must be set to one of the following: DOLNOSLASKIE, KUJAWSKO_POMORSKIE, LUBELSKIE, LUBUSKIE, LODZKIE, MALOPOLSKIE, MAZOWIECKIE, OPOLSKIE, PODKARPACKIE, PODLASKIE, POMORSKIE, SLASKIE, SWIETOKRZYSKIE, WARMINSKO_MAZURSKIE, WIELKOPOLSKIE, ZACHODNIOPOMORSKIE.
        /// </summary>
        /// <value>This field is mandatory if countryCode is set to \"PL\", for other values, currently, it is ignored. For countryCode equalling \"PL\", this field must be set to one of the following: DOLNOSLASKIE, KUJAWSKO_POMORSKIE, LUBELSKIE, LUBUSKIE, LODZKIE, MALOPOLSKIE, MAZOWIECKIE, OPOLSKIE, PODKARPACKIE, PODLASKIE, POMORSKIE, SLASKIE, SWIETOKRZYSKIE, WARMINSKO_MAZURSKIE, WIELKOPOLSKIE, ZACHODNIOPOMORSKIE.</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }
        //TODO: Province maybe is enum ? 

    }
}
