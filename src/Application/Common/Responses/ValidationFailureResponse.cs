namespace Application.Common.Responses
{
    public class ValidationFailureResponse
    {
        public IDictionary<string, string[]> Errors { get; set; }
    }
}
