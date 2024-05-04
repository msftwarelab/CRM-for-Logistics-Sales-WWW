using Application.Common.Responses;

namespace Application.Common
{
    public class ApplicationResponse<T>
    {
        public ApplicationResponse(ApplicationResult<T> applicationResult)
        {
            ApplicationResult = applicationResult;
        }

        public ApplicationResponse(ApplicationError applicationError)
        {
            ApplicationError = applicationError;
        }

        public ApplicationError? ApplicationError { get; }

        public ApplicationResult<T>? ApplicationResult { get; }

        public bool IsSuccessful =>
            ApplicationError == null;
    }
}
