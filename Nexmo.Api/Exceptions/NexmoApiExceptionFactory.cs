using System.Net;

namespace Nexmo.Api.Exceptions
{
    public static class NexmoApiExceptionFactory
    {
        public static NexmoApiException CreateForResponse(HttpStatusCode status)
        {
            var code = (int)status;

            // Supports status codes listed at https://docs.nexmo.com/tools/application-api/api-reference
            switch (code)
            {
                case 401:
                    return new NexmoUnauthorizedException();

                case 404:
                    return new NexmoNotFoundException();

                case 429:
                    return new NexmoRateLimitedException();

                case 500:
                    return new NexmoServerErrorException();

                default:
                    return new NexmoApiException(code, $"error {code}");
            }
        }
    }
}