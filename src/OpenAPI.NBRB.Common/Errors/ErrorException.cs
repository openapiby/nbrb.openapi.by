using System;

namespace OpenAPI.NBRB.Common.Errors
{
    public class ErrorException : Exception
    {
        public ErrorException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public int? StatusCode { get; set; }
    }
}
