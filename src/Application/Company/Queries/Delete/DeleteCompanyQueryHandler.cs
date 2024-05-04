using Application.Common;
using Application.Common.Interfaces;
using Application.Company.Queries.Create;
using Application.Contact.Queries.Create;
using Application.Contact.Queries.Delete;
using Application.Repositories.Stripe;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.DataCenter;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.Delete
{
    public class DeleteCompanyQueryHandler :
        BaseHandler,
        IRequestHandler<DeleteCompanyQuery, ApplicationResponse<DeleteCompanyResponse>>
    {
        private readonly ILogger<DeleteCompanyQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public DeleteCompanyQueryHandler(
            ILogger<DeleteCompanyQueryHandler> logger,
            IStripeApiCustomerService stripeApiCustomerService,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            this.mediator = mediator;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<DeleteCompanyResponse>> Handle(DeleteCompanyQuery request, CancellationToken cancellationToken)
        {
            GlobalCompany company = GetCompany(request);
            if (company == null)
            {
                return GetError<DeleteCompanyResponse>("There is no the company.", ErrorTypeEnum.BadRequest);
            }

            _sharedDbContext.GlobalCompanies.Attach(company);
            _sharedDbContext.GlobalCompanies.Remove(company);
            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);
            return GetResult(new DeleteCompanyResponse(company.GlobalCompanyId), ResultType.Ok);
        }

        private GlobalCompany GetCompany(DeleteCompanyQuery request)
        {
            return _sharedDbContext
               .GlobalCompanies
                .FirstOrDefault(
                    x => x.GlobalCompanyId == request.DeleteCompanyRequest.GlobalCompanyId)!;
        }
    }
}
