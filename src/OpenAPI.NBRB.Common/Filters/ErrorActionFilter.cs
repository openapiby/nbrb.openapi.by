using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OpenAPI.NBRB.Common.Errors;
using OpenAPI.NBRB.Common.Extensions;
using OpenAPI.NBRB.Common.Responses;

namespace OpenAPI.NBRB.Common.Filters
{
    public class ErrorActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                ErrorResponse errorResponse = null;

                switch (context.Exception)
                {
                    case ErrorException errorException:
                        errorResponse = errorException.ToErrorResponse();
                        errorResponse.StatusCode = errorException.StatusCode ?? StatusCodes.Status400BadRequest;
                        context.ExceptionHandled = true;
                        break;

                    case Exception ex:
                        errorResponse = new ErrorResponse
                        {
                            ErrorMessage = $"Unknown error; {ex.Message}",
                            StatusCode = StatusCodes.Status400BadRequest
                        };
                        context.ExceptionHandled = true;
                        break;
                }
                context.Result = new ObjectResult(errorResponse) { StatusCode = errorResponse.StatusCode };
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
