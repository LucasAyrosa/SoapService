using System.ServiceModel;
using SoapService.Models;

namespace SoapService.Contracts
{
    [ServiceContract(Namespace = "http://soapservice.com.br/")]
    public interface IService
    {
        [OperationContract]
        Response SoapServiceMethod(Message Message);
    }
}