using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Stripe;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Contact.Queries.Update
{
    public class UpdateContactQueryHandler :
        BaseHandler,
        IRequestHandler<UpdateContactQuery, ApplicationResponse<UpdateContactResponse>>
    {

        private readonly ILogger<UpdateContactQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public UpdateContactQueryHandler(
            ILogger<UpdateContactQueryHandler> logger,
            IStripeApiCustomerService stripeApiCustomerService,
            ISharedDbContext sharedDbContext,
            IMapper mapper)
        {
            _logger = logger;
            this.mediator = mediator;
            _sharedDbContext = sharedDbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<UpdateContactResponse>> Handle(UpdateContactQuery request, CancellationToken cancellationToken)
        {
            GlobalContact contact = GetContact(request);
            if (contact == null)
            {
                return GetError<UpdateContactResponse>("There is no the Contact.", ErrorTypeEnum.BadRequest);
            }

            if (request.UpdateContactRequest.SubscriberId != null)
                contact.SubscriberId = (int)request.UpdateContactRequest.SubscriberId;
            if (request.UpdateContactRequest.BirthdayDay != null)
                contact.BirthdayDay = (int)request.UpdateContactRequest.BirthdayDay;
            if (request.UpdateContactRequest.BirthdayMonth != null)
                contact.BirthdayMonth = (int)request.UpdateContactRequest.BirthdayMonth;
            if (request.UpdateContactRequest.GlobalCompanyId != null)
                contact.GlobalCompanyId = (int)request.UpdateContactRequest.GlobalCompanyId;
            if (request.UpdateContactRequest.ContactName != null)
                contact.ContactName = request.UpdateContactRequest.ContactName;
            if (request.UpdateContactRequest.ContactOwnerUserIdGlobal != null)
                contact.ContactOwnerUserIdGlobal = (int)request.UpdateContactRequest.ContactOwnerUserIdGlobal;
            if (request.UpdateContactRequest.ContactTypeId != null)
                contact.ContactTypeId = (int)request.UpdateContactRequest.ContactTypeId;
            if (request.UpdateContactRequest.HolidayCards != null)
                contact.HolidayCards = (bool)request.UpdateContactRequest.HolidayCards;
            if (request.UpdateContactRequest.OkToCall != null)
                contact.OkToCall = (bool)request.UpdateContactRequest.OkToCall;
            if (request.UpdateContactRequest.FormerEmployee != null)
                contact.FormerEmployee = (bool)request.UpdateContactRequest.FormerEmployee;
            if (request.UpdateContactRequest.CreatedUserName != null)
                contact.CreatedUserName = request.UpdateContactRequest.CreatedUserName;
            if (request.UpdateContactRequest.UpdateUserName != null)
                contact.UpdateUserName = request.UpdateContactRequest.UpdateUserName;

            contact.LastUpdate = DateTime.Now;

            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);
            return GetResult(new UpdateContactResponse(contact.GlobalContactId), ResultType.Ok);
        }

        private FirstFreightAPI.Entities.Shared.GlobalContact GetContact(UpdateContactQuery request)
        {
            return _sharedDbContext
               .GlobalContacts
                .FirstOrDefault(
                    x => x.GlobalContactId == request.UpdateContactRequest.GlobalContactId)!;
        }
    }
}
