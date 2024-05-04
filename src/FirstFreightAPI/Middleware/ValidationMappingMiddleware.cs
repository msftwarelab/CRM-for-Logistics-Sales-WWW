using Application.Common.Exceptions;
using Application.Common.Responses;

namespace FirstFreightAPI.Middleware
{
    public class ValidationMappingMiddleware
    {
        public readonly RequestDelegate _next;

        public ValidationMappingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ValidationException ex)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                ValidationFailureResponse validationFailureResponse = new()
                {
                    Errors = ex.Errors,
                };
                await context.Response.WriteAsJsonAsync(validationFailureResponse);
            }
        }
    }
}
