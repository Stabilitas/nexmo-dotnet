using System.Net;

namespace Nexmo.Api.Exceptions
{
    public class NexmoServerErrorException : NexmoApiException
    {
        public NexmoServerErrorException() : base((int)HttpStatusCode.InternalServerError, "Server error")
        {
        }
    }
}