using Application.Common;
using Application.Common.Interfaces;
using Application.LinkedSubscriber.Queries.GetLinkedSubscriberIds;
using Application.Repositories.LinkedSubscriber;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Logging;
using static Application.Company.Queries.List.ListCompanyQuery;

namespace Application.Company.Queries.List
{
    public class ListCompanyQueryHandler :
        BaseHandler,
        IRequestHandler<ListCompanyQuery, ApplicationResponse<CompanyListViewModel>>
    {
        private readonly ILogger<ListCompanyQueryHandler> _logger;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;
        private readonly ISender _mediator;
        private readonly ISubscriberRepository subscriberRepository;

        public ListCompanyQueryHandler(
            ILogger<ListCompanyQueryHandler> logger,
            ISharedDbContext sharedDbContext,
            IMapper mapper,
            ISender mediator,
            ISubscriberRepository subscriberRepository)
        {
            _logger = logger;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
            this._mediator = mediator;
            this.subscriberRepository = subscriberRepository;
        }

        public async Task<ApplicationResponse<CompanyListViewModel>> Handle(ListCompanyQuery request, CancellationToken cancellationToken)
        {
            CompanyListViewModel response = new();

            ApplicationResponse<LinkedSubscriberIdsViewModel> linkedSubscriberIdsResponse =
                await _mediator.Send(new GetLinkedSubscriberIdsQuery(request.SubscriberId));
            if (!linkedSubscriberIdsResponse.IsSuccessful)
            {
                return GetError<CompanyListViewModel>(linkedSubscriberIdsResponse.ApplicationError);
            }

            HashSet<int> linkedSubscriberIds =
                linkedSubscriberIdsResponse
                .ApplicationResult!
                .Result
                .LinkedSubscriberIds
                .ToHashSet();

            IQueryable<GlobalCompany> companies =
                _sharedDbContext
                .GlobalCompanies
                .Where(a =>
                    !a.Deleted
                && linkedSubscriberIds.Contains(a.SubscriberId));

            if (request.Filters.Active != null)
            {
                companies =
                    companies
                    .Where(x => x.Active == request.Filters.Active);
            }

            if (request.Filters.IsCustomer != null)
            {
                companies =
                    companies
                    .Where(x => x.IsCustomer == request.Filters.IsCustomer);
            }

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                companies = companies
                    .Where(t =>
                        t.CompanyName.ToLower().Contains(request.Keyword) ||
                        t.SalesTeam.ToLower().Contains(request.Keyword) ||
                        (t.CompanyTypes != null && t.CompanyTypes.ToLower().Contains(request.Keyword)) ||
                        (t.StateProvince != null && t.StateProvince.ToLower().Contains(request.Keyword)) ||
                        (t.PostalCode != null && t.PostalCode.ToLower().Contains(request.Keyword)) ||
                        (t.City != null && t.City.ToLower().Contains(request.Keyword)) ||
                        (t.CountryName != null && t.CountryName.ToLower().Contains(request.Keyword)) ||
                        (t.Address != null && t.Address.ToLower().Contains(request.Keyword)))
                    .Distinct();
            }

            if (!string.IsNullOrEmpty(request.CountryName))
            {
                companies = companies.Where(t => t.CountryName.ToLower().Contains(request.CountryName.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.City))
            {
                companies = companies.Where(t => t.City.ToLower().Contains(request.City.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.PostalCode))
            {
                companies = companies.Where(t => t.PostalCode.ToLower().Contains(request.PostalCode.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.CompanyType))
            {
                companies = companies.Where(t => t.CompanyTypes.ToLower().Contains(request.CompanyType.ToLower()));
            }

            if (request.UserIdGlobal > 0)
            {
                string currentUserUserRole = GetUserRolesByGlobalUserId(request);
                // CRRM6 used GetAccessibleUsers here
                request.FilterGlobalUserIds = _sharedDbContext
                    .GlobalUsers
                    .Where(x =>
                        x.SubscriberId == request.SubscriberId
                        && !x.Deleted
                        //&& (request.LoginEnabled == null || x.LoginEnabled == request.LoginEnabled)
                        && !x.AdminUser)
                    .Select(x =>
                        x.GlobalUserId
                    )
                    .ToList();
                var companiesList = await subscriberRepository.GetGlobalCompaniesAsync(request.FilterGlobalUserIds, request.UserIdGlobal);
                response.Companies.AddRange(companiesList);
            }

            if (companies.Count() > 0)
            {
                // Skip pagination CRM6
            }

            // Skip sorting CRM6

            return GetResult(response, ResultType.Ok);
        }

        private string GetUserRolesByGlobalUserId(ListCompanyQuery request)
        {
            if (request.Filters.Active != null
                && !request.Filters.Active.Value)
            {
                // do nothing -  if inactive show all the inactive companies across linked subscribers, so someone can claim
            }
            else
            {
                if (request.FilterGlobalUserIds == null || request.FilterGlobalUserIds.Count == 0)
                {
                    var globalUser = _sharedDbContext
                        .GlobalUsers
                        .FirstOrDefault(x => x.GlobalUserId == request.UserIdGlobal);

                    if (globalUser != null)
                    {
                        if (!string.IsNullOrEmpty(globalUser.UserRoles))
                        {
                            return globalUser.UserRoles;
                        }
                        else
                        {
                            // Data center code to get user roles
                        }
                    }
                }
            }

            return "";
        }
    }

    public class UserSearchRequest
    {
        public int SubscriberId { get; set; }
        public List<string> LocationCodes { get; set; }
        public List<string> CountryNames { get; set; }
        public int GlobalUserId { get; set; }
        public bool IncludeRSMCSMUsers { get; set; }
        public bool? LoginEnabled { get; set; } = true;
        public string[] MatchRoles { get; set; }
    }
}
