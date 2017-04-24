using System.Net;

namespace Nexmo.Api.Exceptions
{
    public class NexmoNotFoundException : NexmoApiException
    {
        public NexmoNotFoundException() : base((int)HttpStatusCode.NotFound, "Not found")
        {
        }
    }
}