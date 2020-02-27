using System;

namespace SoapService.Models
{
    public class Response
    {
        public Response()
        {
        }
        public Response(string User, string Title, int Code, string Message)
        {
            this.User = User;
            this.Title = Title;
            this.Code = Code;
            this.Message = Message;
            this.ResponseDateTime = DateTime.UtcNow;
        }
        public string User { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public DateTime ResponseDateTime { get; set; }
    }
}