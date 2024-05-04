using Application.Common;
using MediatR;

namespace Application.Company.Queries.Delete
{
    public class DeleteCompanyQuery
        : IRequest<ApplicationResponse<DeleteCompanyResponse>>
    {

        public DeleteCompanyQuery() { }

        public DeleteCompanyQuery(DeleteCompanyRequest deleteCompanyRequest)
        {
            DeleteCompanyRequest = deleteCompanyRequest;
        }

        public DeleteCompanyRequest DeleteCompanyRequest { get; set; }
    }
}
