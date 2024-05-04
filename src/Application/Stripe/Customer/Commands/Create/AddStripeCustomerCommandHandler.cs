using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Customer.Create;
using Domain.Entities.Shared;
using Domain.Enums;
using FirstFreightAPI.Entities.Shared;
using MediatR;
using Microsoft.Extensions.Logging;
using OneOf;

namespace Application.Stripe.Customer.Commands.Create
{
    public class AddStripeCustomerCommandHandler :
        BaseHandler,
        IRequestHandler<AddStripeCustomerCommand, ApplicationResponse<CreateStripeCustomerResponse>>
    {
        private readonly ILogger<AddStripeCustomerCommandHandler> _logger;
        private readonly IStripeApiCustomerService _stripeApiCustomerService;
        private readonly ISharedDbContext _sharedDbContext;

        public AddStripeCustomerCommandHandler(
            ILogger<AddStripeCustomerCommandHandler> logger,
            IStripeApiCustomerService stripeApiCustomerService,
            ISharedDbContext sharedDbContext)
        {
            _logger = logger;
            _stripeApiCustomerService = stripeApiCustomerService;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<CreateStripeCustomerResponse>> Handle(AddStripeCustomerCommand addStripeCustomerCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(addStripeCustomerCommand.CreateStripeCustomerRequest.SubscriberId);
            if (linkSubscriberToStripeCustomer != null)
            {
                return GetError<CreateStripeCustomerResponse>("A Stripe Customer has already been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Try to populate default values
            FirstFreightAPI.Entities.Shared.Subscriber subscriber = GetSubscriber(addStripeCustomerCommand);
            if (subscriber == null)
            {
                return GetError<CreateStripeCustomerResponse>("Invalid subscriber id", ErrorTypeEnum.BadRequest);
            }
            TrySetDefaultValuesIfMissing(addStripeCustomerCommand, subscriber);

            // Create Stripe Customer
            OneOf<CreateStripeCustomerResponse, ReposityFailedResponse> createStripeCustomerResponse = await CreateStripeCustomerAsync(addStripeCustomerCommand, cancellationToken);
            if (createStripeCustomerResponse.TryPickT0(out CreateStripeCustomerResponse? result, out ReposityFailedResponse _))
            {
                await ProcessAndReturnResult(result, subscriber);
            }

            return createStripeCustomerResponse.Match(
                result => GetResult(result, ResultType.Created),
                error => GetError<CreateStripeCustomerResponse>(error)
            );
        }

        private async Task<OneOf<CreateStripeCustomerResponse, ReposityFailedResponse>> CreateStripeCustomerAsync(AddStripeCustomerCommand addStripeCustomerCommand, CancellationToken cancellationToken) =>
            await _stripeApiCustomerService.CreateStripeCustomerAsync(addStripeCustomerCommand.CreateStripeCustomerRequest, cancellationToken);

        private FirstFreightAPI.Entities.Shared.Subscriber GetSubscriber(AddStripeCustomerCommand request) =>
            _sharedDbContext
               .Subscribers
                .FirstOrDefault(
                    x => x.SubscriberId == request.CreateStripeCustomerRequest.SubscriberId)!;

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(int subscriberId) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
                .FirstOrDefault(dbX => dbX.SubscriberId == subscriberId);

        private async Task ProcessAndReturnResult(CreateStripeCustomerResponse result, FirstFreightAPI.Entities.Shared.Subscriber Subscriber)
        {
            LinkSubscriberToStripeCustomer entity = new LinkSubscriberToStripeCustomer
            {
                StripeCustomerId = result.StripeCustomerId,
                SubscriberId = Subscriber.SubscriberId
            };
            await _sharedDbContext.LinkSubscriberToStripeCustomers.AddAsync(entity);

            await _sharedDbContext.SaveChangesAsync(CancellationToken.None);
        }

        private static void TrySetDefaultValuesIfMissing(AddStripeCustomerCommand request, FirstFreightAPI.Entities.Shared.Subscriber subscriber)
        {
            request.CreateStripeCustomerRequest.CustomerName ??= subscriber.CompanyName;
            request.CreateStripeCustomerRequest.CustomerEmail ??= subscriber.Email;
            request.CreateStripeCustomerRequest.CustomerPhone ??= subscriber.Phone;
            request.CreateStripeCustomerRequest.CustomerDescription ??= subscriber.SubscriberType;
        }
    }
}
