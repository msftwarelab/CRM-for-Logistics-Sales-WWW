using Domain.Common;
using Domain.Enums;

namespace Application.Common.Responses
{
    public class ApplicationError
    {
        public ApplicationError(DomainError domainError, ErrorTypeEnum? errorTypeEnum)
        {
            DomainError = domainError;
            ErrorTypeEnum = errorTypeEnum ?? ErrorTypeEnum.Unknown;
        }

        public ErrorTypeEnum ErrorTypeEnum { get; }
        public DomainError DomainError { get; }
    }
}
