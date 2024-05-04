using Application.Common;
using MediatR;

namespace Application.Contact.Queries.List
{
    public class ListContactQuery
          : IRequest<ApplicationResponse<ContactListViewModel>>
    {
        public int SubscriberId { get; set; }
        public int UserId { get; set; }
        public int UserIdGlobal { get; set; }
        public int GlobalCompanyId { get; set; }
        public int ContactTypeId { get; set; }
        public string Keyword { get; set; }
        public string KeywordCountry { get; set; }
        public string KeywordCity { get; set; }
        public string KeywordPostalCode { get; set; }
        public string SortBy { get; set; }
        public int RecordsPerPage { get; set; }
        public int CurrentPage { get; set; }
    }
}
