using System.ServiceModel;

namespace SoapService.Models
{
    [MessageContract]
    public class Message
    {
        [MessageHeader]
        public Header Header { get; set; }
        [MessageBodyMember]
        public Parameters Parameters { get; set; }
    }
}