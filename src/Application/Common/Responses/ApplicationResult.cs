using Domain.Enums;

namespace Application.Common.Responses
{
    public class ApplicationResult<T>
    {
        public ApplicationResult(T result, ResultType resultType, bool isEmptyResponse)
        {
            Result = result;
            ResultType = resultType;
            IsEmptyResponse = isEmptyResponse;
        }

        public T Result { get; }
        public ResultType ResultType { get; }
        public bool IsEmptyResponse { get; }

        public T? GetResponseIfAvailable()
        {
            if (IsEmptyResponse)
            {
                return default;
            }

            return Result;
        }
    }
}
