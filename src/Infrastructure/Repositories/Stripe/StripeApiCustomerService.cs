using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Customer.Create;
using Application.Repositories.Stripe.Entities.Customer.Delete;
using Application.Repositories.Stripe.Entities.Customer.Query;
using Application.Repositories.Stripe.Entities.Customer.Update;
using Microsoft.Extensions.Logging;
using OneOf;
using Stripe;

namespace Infrastructure.ExternalApi.Stripe
{
    public class StripeApiCustomerService : BaseStripeProcessor, IStripeApiCustomerService
    {
        private readonly ILogger<StripeApiCustomerService> _logger;
        private readonly CustomerService _customerService;

        public StripeApiCustomerService(
            ILogger<StripeApiCustomerService> logger,
            CustomerService customerService)
                : base(logger)
        {
            _logger = logger;
            _customerService = customerService;
        }

        public async Task<OneOf<QueryStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> SearchStripeCustomerAsync(QueryStripeCustomerRequest queryStripeCustomerRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand<QueryStripeCustomerResponse, ReposityQueryNotFoundResponse>(async () =>
            {
                string query = $"email:'{queryStripeCustomerRequest.customerEmail}'";
                CustomerSearchOptions options = new()
                {
                    Query = query
                };
                var searchCustomer = await _customerService.SearchAsync(options, null, ct);
                bool isFound = searchCustomer?.Data.Any() ?? false;

                if (isFound)
                {
                    return new QueryStripeCustomerResponse();
                }

                return new ReposityQueryNotFoundResponse();
            });
        }

        public async Task<OneOf<CreateStripeCustomerResponse, ReposityFailedResponse>> CreateStripeCustomerAsync(CreateStripeCustomerRequest customer, CancellationToken ct)
        {
            return await TryProcessStripeCommand<CreateStripeCustomerResponse>(async () =>
            {
                CustomerCreateOptions customerCreateOptions = new()
                {
                    Name = customer.CustomerName,
                    Email = customer.CustomerEmail,
                    Description = customer.CustomerDescription,
                    Phone = customer.CustomerPhone,
                    Metadata = new Dictionary<string, string>
                    {
                        { "SubscriberId", customer.SubscriberId.ToString() }
                    }
                };
                Customer createCustomer = await _customerService.CreateAsync(customerCreateOptions, null, ct);

                return new CreateStripeCustomerResponse(createCustomer.Id);
            });
        }

        public async Task<OneOf<DeleteStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> DeleteStripeCustomerAsync(DeleteStripeCustomerRequest customer, CancellationToken ct)
        {
            return await TryProcessStripeCommand<DeleteStripeCustomerResponse, ReposityQueryNotFoundResponse>(async () =>
            {
                // Delete customer account using customerID
                var deleteCustomer = await _customerService.DeleteAsync(customer.CustomerId, null, null, ct);

                if (string.IsNullOrEmpty(deleteCustomer?.Id)
                    || deleteCustomer.StripeResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return new ReposityQueryNotFoundResponse();
                }

                if (deleteCustomer.StripeResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new ReposityFailedResponse();
                }

                return new DeleteStripeCustomerResponse();
            });
        }

        public async Task<OneOf<UpdateStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> UpdateStripeCustomerAsync(UpdateStripeCustomerRequest customer, CancellationToken ct)
        {
            return await TryProcessStripeCommand<UpdateStripeCustomerResponse, ReposityQueryNotFoundResponse>(async () =>
            {
                // Update the customer account using customerID
                CustomerUpdateOptions customerUpdateOptions = new()
                {
                    Source = customer.Source,
                    Name = customer.CustomerName,
                    Email = customer.CustomerEmail,
                    Description = customer.CustomerDescription,
                    Phone = customer.CustomerPhone,
                    Address = new()
                    {
                        City = customer.Address.City,
                        Country = customer.Address.Country,
                        Line1 = customer.Address.Line1,
                        Line2 = customer.Address.Line2,
                        PostalCode = customer.Address.PostalCode,
                    }
                };
                Customer updateCustomer = await _customerService.UpdateAsync(customer.CustomerId, customerUpdateOptions, null, ct);

                if (string.IsNullOrEmpty(updateCustomer?.Id)
                    || updateCustomer.StripeResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return new ReposityQueryNotFoundResponse();
                }

                if (updateCustomer.StripeResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new ReposityFailedResponse();
                }

                return new UpdateStripeCustomerResponse();
            });
        }
    }
}
