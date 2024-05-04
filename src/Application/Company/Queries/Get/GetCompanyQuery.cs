using Application.Common;
using MediatR;

namespace Application.Company.Queries.Get
{
    public class GetCompanyQuery
        : IRequest<ApplicationResponse<CompanyViewModel>>
    {
        public GetCompanyQuery() { }

        public GetCompanyQuery(int globalCompanyId, int subscriberId)
        {
            GlobalCompanyId = globalCompanyId;
            SubscriberId = subscriberId;
        }

        public int GlobalCompanyId { get; }
        public int SubscriberId { get; }
    }
}
