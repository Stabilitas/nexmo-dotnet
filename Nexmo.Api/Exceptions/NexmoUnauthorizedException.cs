using System.Net;

namespace Nexmo.Api.Exceptions
{
    public class NexmoUnauthorizedException : NexmoApiException
    {
        public NexmoUnauthorizedException() : base((int)HttpStatusCode.Unauthorized, "Unauthorized")
        {
        }
    }
}