using System.Runtime.Serialization;

namespace SoapService.Models
{
    [DataContract]
    public class Parameters
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}