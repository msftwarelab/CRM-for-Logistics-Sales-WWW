using Application.Common;
using Domain.Enums;

namespace Application.Repositories.Common
{
    public class ReposityFailedResponse
    {
        public ReposityFailedResponse()
        {

        }

        public ReposityFailedResponse(Exception exception)
        {
            Exception = exception;
        }

        public ReposityFailedResponse(Exception exception, string publicFacingErrorMessage, ErrorTypeEnum? errorTypeEnumOverride = null)
        {
            Exception = exception;
            PublicFacingErrorMessage = publicFacingErrorMessage;
            ErrorTypeEnumOverride = errorTypeEnumOverride;
        }

        public Exception? Exception { get; set; }
        public string? PublicFacingErrorMessage { get; }
        public ErrorTypeEnum? ErrorTypeEnumOverride { get; }

        public bool IsExceptionAvailable =>
            Exception != null;

        public bool IsPublicFacingErrorMessageAvailable =>
            !string.IsNullOrEmpty(PublicFacingErrorMessage);
    }
}