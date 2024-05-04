using Application.Common;
using MediatR;

namespace Application.Company.Queries.Create
{
    public class CreateCompanyQuery
        : IRequest<ApplicationResponse<CreateCompanyResponse>>
    {
        public CreateCompanyQuery() 
        {
        
        }

        public CreateCompanyQuery(CreateCompanyRequest createCompanyRequest)
        {
            CreateCompanyRequest = createCompanyRequest;
        }

        public CreateCompanyRequest CreateCompanyRequest { get; set; }
    }
}
