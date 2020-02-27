using SoapService.Contracts;
using SoapService.Models;

namespace SoapService.Services
{
    public class Service : IService
    {
        public Response SoapServiceMethod(Message Message)
        {
            return new Response(
                Message.Header.User,
                Message.Parameters.Title,
                Message.Parameters.Code,
                Message.Parameters.Message
            );
        }
    }
}