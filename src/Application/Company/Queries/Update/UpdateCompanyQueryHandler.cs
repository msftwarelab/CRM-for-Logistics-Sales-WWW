using Application.Common;
using Application.Common.Interfaces;
using Application.Company.Queries.Delete;
using Application.Contact.Queries.Update;
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

namespace Application.Company.Queries.Update
{
    public class UpdateCompanyQueryHandler :
        BaseHandler,
        IRequestHandler<UpdateCompanyQuery, ApplicationResponse<UpdateCompanyResponse>>
    {
        private readonly ILogger<UpdateCompanyQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public UpdateCompanyQueryHandler(
            ILogger<UpdateCompanyQueryHandler> logger,
            IStripeApiCustomerService stripeApiCustomerService,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            this.mediator = mediator;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<UpdateCompanyResponse>> Handle(UpdateCompanyQuery request, CancellationToken cancellationToken)
        {
            GlobalCompany company = GetCompany(request);
            if (company == null)
            {
                return GetError<UpdateCompanyResponse>("There is no the company.", ErrorTypeEnum.BadRequest);
            }

            if (request.UpdateCompanyRequest.SubscriberId != null)
                company.SubscriberId = (int)request.UpdateCompanyRequest.SubscriberId;
            if (request.UpdateCompanyRequest.AdminOverideActive != null)
                company.AdminOverideActive = (bool)request.UpdateCompanyRequest.AdminOverideActive;
            if (request.UpdateCompanyRequest.Claimed != null)
                company.Claimed = (bool)request.UpdateCompanyRequest.Claimed;
            if (request.UpdateCompanyRequest.ClaimedUserId != null)
                company.ClaimedUserId = (int)request.UpdateCompanyRequest.ClaimedUserId;
            if (request.UpdateCompanyRequest.ClaimedUserIdGlobal != null)
                company.ClaimedUserIdGlobal = (int)request.UpdateCompanyRequest.ClaimedUserIdGlobal;
            if (request.UpdateCompanyRequest.CompanyId != null)
                company.CompanyId = (int)request.UpdateCompanyRequest.CompanyId;
            if (request.UpdateCompanyRequest.CompanyName != null)
                company.CompanyName = request.UpdateCompanyRequest.CompanyName;
            if (request.UpdateCompanyRequest.CompanyOwnerUserId != null)
                company.CompanyOwnerUserId = (int)request.UpdateCompanyRequest.CompanyOwnerUserId;
            if (request.UpdateCompanyRequest.CompanyOwnerUserIdGlobal != null)
                company.CompanyOwnerUserIdGlobal = (int)request.UpdateCompanyRequest.CompanyOwnerUserIdGlobal;
            if (request.UpdateCompanyRequest.CountryName != null)
                company.CountryName = request.UpdateCompanyRequest.CountryName;
            if (request.UpdateCompanyRequest.CreatedUserId != null)
                company.CreatedUserId = (int)request.UpdateCompanyRequest.CreatedUserId;
            if (request.UpdateCompanyRequest.CreatedUserIdGlobal != null)
                company.CreatedUserIdGlobal = (int)request.UpdateCompanyRequest.CreatedUserIdGlobal;
            if (request.UpdateCompanyRequest.CreatedUserName != null)
                company.CreatedUserName = request.UpdateCompanyRequest.CreatedUserName;
            if (request.UpdateCompanyRequest.CreditLimit != null)
                company.CreditLimit = (int)request.UpdateCompanyRequest.CreditLimit;
            if (request.UpdateCompanyRequest.DataCenter != null)
                company.DataCenter = request.UpdateCompanyRequest.DataCenter;
            if (request.UpdateCompanyRequest.EmailAddress != null)
                company.EmailAddress = request.UpdateCompanyRequest.EmailAddress;
            if (request.UpdateCompanyRequest.GlobalCompanyOwnerGlobalUserId != null)
                company.GlobalCompanyOwnerGlobalUserId = (int)request.UpdateCompanyRequest.GlobalCompanyOwnerGlobalUserId;
            if (request.UpdateCompanyRequest.IpAddress != null)
                company.IpAddress = request.UpdateCompanyRequest.IpAddress;
            if (request.UpdateCompanyRequest.IsCustomer != null)
                company.IsCustomer = (bool)request.UpdateCompanyRequest.IsCustomer;
            if (request.UpdateCompanyRequest.NumberOfEmployees != null)
                company.NumberOfEmployees = (int)request.UpdateCompanyRequest.NumberOfEmployees;
            if (request.UpdateCompanyRequest.PrimaryContactId != null)
                company.PrimaryContactId = (int)request.UpdateCompanyRequest.PrimaryContactId;
            if (request.UpdateCompanyRequest.PrimaryGlobalContactId != null)
                company.PrimaryGlobalContactId = (int)request.UpdateCompanyRequest.PrimaryGlobalContactId;
            if (request.UpdateCompanyRequest.SourceDataCenterCompanyId != null)
                company.SourceDataCenterCompanyId = (int)request.UpdateCompanyRequest.SourceDataCenterCompanyId;
            if (request.UpdateCompanyRequest.SourceSubscriberId != null)
                company.SourceSubscriberId = (int)request.UpdateCompanyRequest.SourceSubscriberId;
            if (request.UpdateCompanyRequest.UpdateUserId != null)
                company.UpdateUserId = (int)request.UpdateCompanyRequest.UpdateUserId;
            if (request.UpdateCompanyRequest.UpdateUserName != null)
                company.UpdateUserName = request.UpdateCompanyRequest.UpdateUserName;
            if (request.UpdateCompanyRequest.ConversionAccountId != null)
                company.ConversionAccountId = (int)request.UpdateCompanyRequest.ConversionAccountId;
            if (request.UpdateCompanyRequest.ConversionLeadId != null)
                company.ConversionLeadId = (int)request.UpdateCompanyRequest.ConversionLeadId;
            if (request.UpdateCompanyRequest.ConversionGlobalCompanyId != null)
                company.ConversionGlobalCompanyId = (int)request.UpdateCompanyRequest.ConversionGlobalCompanyId;
            if (request.UpdateCompanyRequest.CurrentYearAirTonnageTotal != null)
                company.CurrentYearAirTonnageTotal = (double)request.UpdateCompanyRequest.CurrentYearAirTonnageTotal;
            if (request.UpdateCompanyRequest.CurrentYearAirTonnageShare != null)
                company.CurrentYearAirTonnageShare = (double)request.UpdateCompanyRequest.CurrentYearAirTonnageShare;
            if (request.UpdateCompanyRequest.NextYearAirTonnageObjective != null)
                company.NextYearAirTonnageObjective = (double)request.UpdateCompanyRequest.NextYearAirTonnageObjective;
            if (request.UpdateCompanyRequest.CurrentYearOceanTeutotal != null)
                company.CurrentYearOceanTeutotal = (double)request.UpdateCompanyRequest.CurrentYearOceanTeutotal;
            if (request.UpdateCompanyRequest.CurrentYearOceanTeushare != null)
                company.CurrentYearOceanTeushare = (double)request.UpdateCompanyRequest.CurrentYearOceanTeushare;
            if (request.UpdateCompanyRequest.NextYearOceanTeuobjective != null)
                company.NextYearOceanTeuobjective = (double)request.UpdateCompanyRequest.NextYearOceanTeuobjective;

            company.LastUpdate = DateTime.Now;

            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);
            return GetResult(new UpdateCompanyResponse(company.GlobalCompanyId), ResultType.Ok);
        }

        private GlobalCompany GetCompany(UpdateCompanyQuery request)
        {
            return _sharedDbContext
               .GlobalCompanies
                .FirstOrDefault(
                    x => x.GlobalCompanyId == request.UpdateCompanyRequest.GlobalCompanyId)!;
        }
    }
}
