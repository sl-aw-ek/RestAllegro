using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Authorization
{
    [DataContract]
    public  class TokenForApplicationResponse
    {
        [DataMember(Name = "access_token")]
        public string AccesToken { get; set; }

        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// expires token time in seconds
        /// </summary>

        [DataMember(Name = "expires_in")]
        public int ExpiresIn { get; set; }

        [DataMember(Name = "scope")]
        public string Scope { get; set; }

        [DataMember(Name = "allegro_api")]
        public string AllegroApi { get; set; }

        [DataMember(Name = "jti")]
        public string Jti { get; set; }


    }
}
