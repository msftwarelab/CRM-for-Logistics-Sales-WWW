using Application.Common;
using Application.Common.Interfaces;
using Application.Company.Common;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Application.Company.Queries.Get
{
    internal class GetCompanyQueryHandler :
        BaseHandler,
        IRequestHandler<GetCompanyQuery, ApplicationResponse<CompanyViewModel>>
    {
        private readonly ILogger<GetCompanyQueryHandler> _logger;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;
        public GetCompanyQueryHandler(
            ILogger<GetCompanyQueryHandler> logger,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<CompanyViewModel>> Handle(GetCompanyQuery request, CancellationToken cancellationToken)
        {
            CompanyDto? company = await GetCompany(request, cancellationToken);

            if (company == null)
            {
                return GetError<CompanyViewModel>(ErrorTypeEnum.ResourceNotFound);
            }

            return GetResult(new CompanyViewModel(company), ResultType.Ok);
        }

        private async Task<CompanyDto?> GetCompany(GetCompanyQuery request, CancellationToken cancellationToken)
        {
            return await _sharedDbContext
                    .GlobalCompanies
                    .AsNoTracking()
                    .Where(a => a.GlobalCompanyId == request.GlobalCompanyId)
                    .ProjectTo<CompanyDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
