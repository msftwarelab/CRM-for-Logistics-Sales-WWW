using Application.Common.Responses;
using Application.Repositories.Common;
using Domain.Common;
using Domain.Enums;

namespace Application.Common
{
    public abstract class BaseHandler
    {
        private protected static ApplicationResponse<T> GetError<T>(ReposityFailedResponse reposityFailedResponse)
        {
            return GetError<T>(reposityFailedResponse.PublicFacingErrorMessage, reposityFailedResponse.ErrorTypeEnumOverride);
        }

        private protected static ApplicationResponse<T> GetError<T>(ErrorTypeEnum? errorTypeEnum = null)
            => GetError<T>(null, errorTypeEnum);

        private protected static ApplicationResponse<T> GetError<T>(ApplicationError? applicationError)
        {
            if (applicationError == null)
            {
                return GetError<T>();
            }

            return new ApplicationResponse<T>(applicationError);
        }

        private protected static ApplicationResponse<T> GetError<T>(string? publicFacingErrorMessage, ErrorTypeEnum? errorTypeEnum = null)
        {
            return new ApplicationResponse<T>(
                new ApplicationError(
                    new DomainError
                    {
                        PublicFacingErrorMessage = publicFacingErrorMessage
                    }, errorTypeEnum ?? ErrorTypeEnum.Internal));
        }

        private protected static ApplicationResponse<T> GetResult<T>(T result, ResultType resultType, bool isEmptyResponse = false)
        {
            return new ApplicationResponse<T>(
                new ApplicationResult<T>(result, resultType, isEmptyResponse));
        }
    }
}
