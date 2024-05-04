using Application.Common;
using Application.Common.Interfaces;
using Application.Company.Queries.List;
using Application.Contact.Common;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using static Application.Company.Queries.List.ListCompanyQuery;

namespace Application.Contact.Queries.List
{
    public class ListContactQueryHandler :
        BaseHandler,
        IRequestHandler<ListContactQuery, ApplicationResponse<ContactListViewModel>>
    {
        private readonly ILogger<ListContactQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public ListContactQueryHandler(
            ILogger<ListContactQueryHandler> logger,
            ISender mediator,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            this.mediator = mediator;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<ContactListViewModel>> Handle(ListContactQuery request, CancellationToken cancellationToken)
        {
            ContactListViewModel response = new();

            IQueryable<GlobalContact> contacts = _sharedDbContext
            .GlobalContacts
            .AsNoTracking()
            .Where(a => !a.Deleted // Not deleted
                && a.GlobalContactId > 0 // Valid global contact id
                && (!string.IsNullOrEmpty(a.FirstName)
                || !string.IsNullOrEmpty(a.LastName)));

            var temp = contacts.Count();

            if (request.SubscriberId > 0)
            {
                contacts = FilterSubscriberId(request, contacts);
            }

            temp = contacts.Count();

            if (request.UserId > 0)
            {
                var companyFilter = new ListCompanyQuery()
                {
                    SubscriberId = request.SubscriberId,
                    UserId = request.UserId,
                    UserIdGlobal = request.UserIdGlobal,
                    Filters = new _filters
                    {
                        Active = true
                    }
                };

                ApplicationResponse<CompanyListViewModel> companyResponse =
                    await mediator.Send(companyFilter, cancellationToken);

                if (!companyResponse.IsSuccessful)
                {
                    return GetError<ContactListViewModel>("TODO ERROR");
                }

                CompanyListViewModel company = companyResponse.ApplicationResult!.Result;

                var finalContacts = company.Companies.Join(contacts, c => c.GlobalCompanyId, c => c.GlobalCompanyId, (c, cc) => cc).Distinct();
                response.Contacts.AddRange(finalContacts.Select(x => new ContactDto
                {
                    ContactName = x.FirstName + " " + x.LastName
                }));
                return GetResult(new ContactListViewModel(), ResultType.Ok);
            }

            response.Contacts.AddRange(contacts.Select(x => new ContactDto
            {
                ContactName = x.FirstName + " " + x.LastName
            }));
            return GetResult(new ContactListViewModel(), ResultType.Ok);
        }

        private IQueryable<GlobalContact> FilterSubscriberId(ListContactQuery request, IQueryable<GlobalContact> contacts) =>
        contacts.Where(a => a.SubscriberId == request.SubscriberId);

        private Expression<Func<GlobalContact, bool>> IsValidContact() =>
                a => !a.Deleted && a.GlobalContactId > 0 && (!string.IsNullOrEmpty(a.FirstName) || !string.IsNullOrEmpty(a.LastName));

        private bool IsEitherFirstOrLastNameValid(GlobalContact a) =>
            !string.IsNullOrEmpty(a.FirstName)
            || !string.IsNullOrEmpty(a.LastName);
    }
}
