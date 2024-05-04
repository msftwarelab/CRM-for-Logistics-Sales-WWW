using Application.Common;
using Application.Common.Responses;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FirstFreightAPI.Controllers.Base
{
    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender? _mediator;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

        private protected IActionResult GetResponse<T>(ApplicationResponse<T> response)
            where T : class
        {
            if (!response.IsSuccessful)
            {
                return GetErrorfulResponse(response.ApplicationError);
            }

            return GetSuccessfulResponse(response.ApplicationResult);
        }

        [NonAction]
        private IActionResult GetSuccessfulResponse<T>(ApplicationResult<T>? applicationResult)
            where T : class =>
            (applicationResult?.ResultType) switch
            {
                ResultType.Created => StatusCode(StatusCodes.Status201Created, applicationResult?.GetResponseIfAvailable()),
                ResultType.NotModified => StatusCode(StatusCodes.Status304NotModified, applicationResult?.GetResponseIfAvailable()),
                _ => Ok(applicationResult?.GetResponseIfAvailable()),
            };


        [NonAction]
        private IActionResult GetErrorfulResponse(ApplicationError? applicationError) =>
            (applicationError?.ErrorTypeEnum) switch
            {
                ErrorTypeEnum.ResourceNotFound => base.NotFound(applicationError?.DomainError?.PublicFacingErrorMessage),
                ErrorTypeEnum.BadRequest when !string.IsNullOrEmpty(applicationError?.DomainError?.PublicFacingErrorMessage) => GetBadRequestResponse(applicationError),
                _ => base.StatusCode(GetErrorTypeEnum(applicationError?.ErrorTypeEnum), applicationError?.DomainError?.PublicFacingErrorMessage),
            };

        private ObjectResult GetBadRequestResponse(ApplicationError applicationError)
        {
            ValidationFailureResponse validationFailureResponse = new()
            {
                Errors = new Dictionary<string, string[]>()
                {
                    { "Error", new string[] { applicationError.DomainError!.PublicFacingErrorMessage! } }
                }
            };

            return base.StatusCode(StatusCodes.Status400BadRequest, validationFailureResponse);
        }

        private static int GetErrorTypeEnum(ErrorTypeEnum? errorTypeEnum) =>
            errorTypeEnum switch
            {
                ErrorTypeEnum.ResourceNotFound => StatusCodes.Status404NotFound,
                ErrorTypeEnum.BadRequest => StatusCodes.Status400BadRequest,
                _ => StatusCodes.Status500InternalServerError,
            };
    }
}
