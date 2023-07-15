using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Authorization
{
    [DataContract]
    [Serializable]
    public  class UserToken
    {
        [DataMember(Name = "access_token")]
        public string AccesToken { get; set; }
        [DataMember(Name = "refresh_token")]
        public string RefreshToken { get; set; }
        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }
        [DataMember(Name = "expires_in")]
        public long ExpiriesIn { get; set; }
        [DataMember(Name = "scope")]
        public string Scope { get; set; }
        [DataMember(Name = "jti")]
        public string Jit { get; set; }
        public override string ToString()
        {
            return "TokenOauth";
        }
    }
}
