using Application.Common;
using MediatR;

namespace Application.Company.Queries.List
{
    public class ListCompanyQuery
        : IRequest<ApplicationResponse<CompanyListViewModel>>
    {
        public int SubscriberId { get; set; }
        public int UserId { get; set; }
        public int UserIdGlobal { get; set; }
        public _filters Filters { get; set; } = new _filters();
        public List<int> FilterGlobalUserIds { get; set; }
        public string FilterType { get; set; }
        public int RecordsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string Keyword { get; set; }
        public string CompanyType { get; set; }
        public string SortBy { get; set; }
        public int LocationId { get; set; }
        public string CountryCode { get; set; }
        public int SalesRep { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public bool IsCustomer { get; set; }

        public class _filters
        {
            public bool? IsCustomer { get; set; }
            public bool? Active { get; set; }
        }
    }
}
