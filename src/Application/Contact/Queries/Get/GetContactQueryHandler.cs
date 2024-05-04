using AutoMapper;
using AutoMapper.QueryableExtensions;
using Application.Common;
using Application.Common.Interfaces;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Contact.Common;
using Application.Common.Dtos;
using Microsoft.Extensions.Logging;

namespace Application.Contact.Queries.Get
{
    public class GetContactQueryHandler :
        BaseHandler,
        IRequestHandler<GetContactQuery, ApplicationResponse<ContactViewModel>>
    {
        private readonly ILogger<GetContactQueryHandler> _logger;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;
        public GetContactQueryHandler(
            ILogger<GetContactQueryHandler> logger,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<ContactViewModel>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            ContactDto? contact = await GetContact(request, cancellationToken);

            if (contact == null)
            {
                return GetError<ContactViewModel>(ErrorTypeEnum.ResourceNotFound);
            }

            DocumentDto? document = await GetProfilePictureDocument(request, cancellationToken);

            return GetResult(new ContactViewModel(contact, document), ResultType.Ok);
        }

        private async Task<ContactDto?> GetContact(GetContactQuery request, CancellationToken cancellationToken)
        {
            return await _sharedDbContext
                    .GlobalContacts
                    .AsNoTracking()
                    .Where(a => a.GlobalContactId == request.GlobalContactId)
                    .ProjectTo<ContactDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
        }

        private async Task<DocumentDto?> GetProfilePictureDocument(GetContactQuery request, CancellationToken cancellationToken)
        {
            DocumentDto? document =
                await _sharedDbContext
                    .Documents
                    .AsNoTracking()
                    .Where(a =>
                        a.GlobalContactId == request.GlobalContactId
                        && a.SubscriberId == request.SubscriberId)
                    .ProjectTo<DocumentDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);

            if (document == null)
            {
                _logger.LogWarning("No document found for {arg0}: {arg1} and {arg2}: {arg3}",
                    nameof(request.GlobalContactId),
                    request.GlobalContactId,
                    nameof(request.SubscriberId),
                    request.SubscriberId);
            }

            return document;
        }
    }
}