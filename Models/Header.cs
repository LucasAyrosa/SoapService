using System.Runtime.Serialization;

namespace SoapService.Models
{
    [DataContract]
    public class Header
    {
        [DataMember]
        public string User { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}