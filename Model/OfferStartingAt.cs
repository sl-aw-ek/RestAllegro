using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Model
{
    //TODO: What is this? 
    [DataContract]
    public class OfferStartingAt 
    {
        private DateTime _dateTime { get; set; }

        /// <summary>
        /// Change to dateTime !!! 
        /// </summary>
        [DataMember(Name = "startingAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startingAt")]
        public string StartingAt {
            get { return _dateTime.ToString("yyyy-MM-dd'T'HH:mm:ss.SSSZ"); }
            set { _dateTime = DateTime.Parse(value); }
        }
    }
}
