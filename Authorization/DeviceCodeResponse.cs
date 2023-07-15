﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestAllegro.Authorization
{
    [DataContract]
    public class DeviceCodeResponse
    {
        [DataMember(Name = "user_code")]
        public string UserCode { get; set; }
        [DataMember(Name = "device_code")]
        public string DeviceCode { get; set; }
        [DataMember(Name = "expires_in")]
        public int ExpiresIn { get; set; }
        [DataMember(Name = "interval")]
        public int Interval { get; set; }
        [DataMember(Name = "verification_uri")]
        public string VerificationUri { get; set; }
        [DataMember(Name = "verification_uri_complete")]
        public string VerificationUriComplete { get; set; }
    }
}
