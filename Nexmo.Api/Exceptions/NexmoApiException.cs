using System;

namespace Nexmo.Api.Exceptions
{
    public class NexmoApiException : Exception
    {
        public int Status { get; set; }

        public NexmoApiException(int status, string msg) : base(msg)
        {
            Status = status;
        }
    }
}