using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Stripe;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Contact.Queries.Delete
{
    public class DeleteContactQueryHandler :
        BaseHandler,
        IRequestHandler<DeleteContactQuery, ApplicationResponse<DeleteContactResponse>>
    {
        private readonly ILogger<DeleteContactQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public DeleteContactQueryHandler(
            ILogger<DeleteContactQueryHandler> logger,
            IStripeApiCustomerService stripeApiCustomerService,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            this.mediator = mediator;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<DeleteContactResponse>> Handle(DeleteContactQuery request, CancellationToken cancellationToken)
        {
            GlobalContact contact = GetContact(request);
            if (contact == null)
            {
                return GetError<DeleteContactResponse>("There is no the Contact.", ErrorTypeEnum.BadRequest);
            }

            _sharedDbContext.GlobalContacts.Attach(contact);
            _sharedDbContext.GlobalContacts.Remove(contact);
            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);
            return GetResult(new DeleteContactResponse(contact.GlobalContactId), ResultType.Ok);
        }

        private FirstFreightAPI.Entities.Shared.GlobalContact GetContact(DeleteContactQuery request)
        {
            return _sharedDbContext
               .GlobalContacts
                .FirstOrDefault(
                    x => x.GlobalContactId == request.DeleteContactRequest.GlobalContactId)!;
        }
    }
}
