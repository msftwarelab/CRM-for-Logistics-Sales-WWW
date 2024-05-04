using Application.Common;
using MediatR;

namespace Application.Company.Queries.Update
{
    public class UpdateCompanyQuery
        : IRequest<ApplicationResponse<UpdateCompanyResponse>>
    {
        public UpdateCompanyQuery() { }

        public UpdateCompanyQuery(UpdateCompanyRequest updateCompanyRequest)
        {
            UpdateCompanyRequest = updateCompanyRequest;
        }

        public UpdateCompanyRequest UpdateCompanyRequest { get; set; }
    }
}
