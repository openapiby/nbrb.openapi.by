using OpenAPI.NBRB.Common.Errors;
using OpenAPI.NBRB.Common.Responses;

namespace OpenAPI.NBRB.Common.Extensions
{
    public static class ErrorExtensions
    {
        public static ErrorResponse ToErrorResponse(this ErrorException errorException)
        {
            return new ErrorResponse
            {
                ErrorMessage = errorException.Message
            };
        }
    }
}
