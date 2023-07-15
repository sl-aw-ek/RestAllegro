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
    /// 	string Enum: "VAT" "VAT_MARGIN" "WITHOUT_VAT" "NO_INVOICE" Invoice type
    /// </summary>
    [DataContract]
    public class Payments
    {
        /// <summary>
        /// Invoice type
        /// </summary>
        /// <value>Invoice type</value>
        [DataMember(Name = "invoice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoice")]
        public InvoiceType Invoice { get; set; }



        public enum InvoiceType
        {
            VAT =1,
            VAT_MARGIN =2,
            WITHOUT_VAT =3,
            NO_INVOICE = 4
        }
    }
}
