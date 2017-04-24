namespace Nexmo.Api.Exceptions
{
    public class NexmoRateLimitedException : NexmoApiException
    {
        public NexmoRateLimitedException() : base(429, "Rate limited")
        {
        }
    }
}