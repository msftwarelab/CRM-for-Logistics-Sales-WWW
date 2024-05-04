using Application.Common;
using Application.Common.Interfaces;
using Application.Contact.Queries.Create;
using Application.Repositories.Stripe;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.DataCenter;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.Create
{
    public class CreateCompanyQueryHandler :
        BaseHandler,
        IRequestHandler<CreateCompanyQuery, ApplicationResponse<CreateCompanyResponse>>
    {
        private readonly ILogger<CreateContactQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public CreateCompanyQueryHandler(
            ILogger<CreateContactQueryHandler> logger,
            IStripeApiCustomerService stripeApiCustomerService,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            this.mediator = mediator;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<CreateCompanyResponse>> Handle(CreateCompanyQuery request, CancellationToken cancellationToken)
        {
            GlobalCompany company = GetCompany(request);
            if (company != null)
            {
                return GetError<CreateCompanyResponse>("A Company has already been created.", ErrorTypeEnum.BadRequest);
            }

            company = new GlobalCompany
            {
                SubscriberId = request.CreateCompanyRequest.SubscriberId,
                Active = request.CreateCompanyRequest.Active,
                AdminOverideActive = request.CreateCompanyRequest.AdminOverideActive,
                Claimed = request.CreateCompanyRequest.Claimed,
                ClaimedUserId = request.CreateCompanyRequest.ClaimedUserId,
                ClaimedUserIdGlobal = request.CreateCompanyRequest.ClaimedUserIdGlobal,
                CompanyId = request.CreateCompanyRequest.CompanyId,
                CompanyName = request.CreateCompanyRequest.CompanyName,
                CompanyOwnerUserId = request.CreateCompanyRequest.CompanyOwnerUserId,
                CompanyOwnerUserIdGlobal = request.CreateCompanyRequest.CompanyOwnerUserIdGlobal,
                CountryName = request.CreateCompanyRequest.CountryName,
                CreatedUserId = request.CreateCompanyRequest.CreatedUserId,
                CreatedUserIdGlobal = request.CreateCompanyRequest.CreatedUserIdGlobal,
                CreatedUserName = request.CreateCompanyRequest.CreatedUserName,
                CreditLimit = request.CreateCompanyRequest.CreditLimit,
                DataCenter = request.CreateCompanyRequest.DataCenter,
                EmailAddress = request.CreateCompanyRequest.EmailAddress,
                GlobalCompanyOwnerGlobalUserId = request.CreateCompanyRequest.GlobalCompanyOwnerGlobalUserId,
                IpAddress = request.CreateCompanyRequest.IpAddress,
                IsCustomer = request.CreateCompanyRequest.IsCustomer,
                NumberOfEmployees = request.CreateCompanyRequest.NumberOfEmployees,
                PrimaryContactId = request.CreateCompanyRequest.PrimaryContactId,
                PrimaryGlobalContactId = request.CreateCompanyRequest.PrimaryGlobalContactId,
                SourceDataCenterCompanyId = request.CreateCompanyRequest.SourceDataCenterCompanyId,
                SourceSubscriberId = request.CreateCompanyRequest.SourceSubscriberId,
                UpdateUserId = request.CreateCompanyRequest.UpdateUserId,
                UpdateUserName = request.CreateCompanyRequest.UpdateUserName,
                ConversionAccountId = request.CreateCompanyRequest.ConversionAccountId,
                ConversionLeadId = request.CreateCompanyRequest.ConversionLeadId,
                ConversionGlobalCompanyId = request.CreateCompanyRequest.ConversionGlobalCompanyId,
                CurrentYearAirTonnageTotal = request.CreateCompanyRequest.CurrentYearAirTonnageTotal,
                CurrentYearAirTonnageShare = request.CreateCompanyRequest.CurrentYearAirTonnageShare,
                NextYearAirTonnageObjective = request.CreateCompanyRequest.NextYearAirTonnageObjective,
                CurrentYearOceanTeutotal = request.CreateCompanyRequest.CurrentYearOceanTeutotal,
                CurrentYearOceanTeushare = request.CreateCompanyRequest.CurrentYearOceanTeushare,
                NextYearOceanTeuobjective = request.CreateCompanyRequest.NextYearOceanTeuobjective,
                CreatedDate = DateTime.Now,
                LastUpdate = DateTime.Now,
            };

            await _sharedDbContext.GlobalCompanies.AddAsync(company);
            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);

            return GetResult(new CreateCompanyResponse(company.GlobalCompanyId), ResultType.Ok);
        }

        private GlobalCompany GetCompany(CreateCompanyQuery request)
        {
            return _sharedDbContext
               .GlobalCompanies
                .FirstOrDefault(
                    x => x.SubscriberId == request.CreateCompanyRequest.SubscriberId)!;
        }
    }
}
