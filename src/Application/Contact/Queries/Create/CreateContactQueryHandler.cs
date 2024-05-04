using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Stripe;
using AutoMapper;
using Domain.Enums;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Contact.Queries.Create
{
    public class CreateContactQueryHandler :
        BaseHandler,
        IRequestHandler<CreateContactQuery, ApplicationResponse<CreateContactResponse>>
    {
        private readonly ILogger<CreateContactQueryHandler> _logger;
        private readonly ISender mediator;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly IMapper _mapper;

        public CreateContactQueryHandler(
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

        public async Task<ApplicationResponse<CreateContactResponse>> Handle(CreateContactQuery request, CancellationToken cancellationToken)
        {            
            
            GlobalContact contact = GetContact(request);
            if (contact != null)
            {
                return GetError<CreateContactResponse>("A Contact has already been created.", ErrorTypeEnum.BadRequest);
            }

            contact = new GlobalContact
            {
                SubscriberId = request.CreateContactRequest.SubscriberId,
                BirthdayDay = request.CreateContactRequest.BirthdayDay,
                BirthdayMonth = request.CreateContactRequest.BirthdayMonth,
                GlobalCompanyId = request.CreateContactRequest.GlobalCompanyId,
                ContactName = request.CreateContactRequest.ContactName,
                ContactOwnerUserIdGlobal = request.CreateContactRequest.ContactOwnerUserIdGlobal,
                ContactTypeId = request.CreateContactRequest.ContactTypeId,
                HolidayCards = request.CreateContactRequest.HolidayCards,
                OkToCall = request.CreateContactRequest.OkToCall,
                FormerEmployee = request.CreateContactRequest.FormerEmployee,
                CreatedDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                CreatedUserName = request.CreateContactRequest.CreatedUserName,
                UpdateUserName = request.CreateContactRequest.UpdateUserName
            };


            await _sharedDbContext.GlobalContacts.AddAsync(contact);
            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);

            return GetResult(new CreateContactResponse(contact.GlobalContactId), ResultType.Ok);
        }


        private GlobalContact GetContact(CreateContactQuery request)
        {
            return _sharedDbContext
               .GlobalContacts
                .FirstOrDefault(
                    x => x.SubscriberId == request.CreateContactRequest.SubscriberId)!;
        }
    }
}
