using Application.Common.Interfaces;
using Application.Repositories.LinkedSubscriber;
using Application.Repositories.Stripe;
using Infrastructure.Dapper;
using Infrastructure.Dapper.Repositories.Subscriber;
using Infrastructure.ExternalApi.Stripe;
using Infrastructure.Repositories.Stripe;
using Microsoft.Extensions.DependencyInjection;
using Stripe;
using Stripe.Checkout;

namespace Infrastructure.Configuration
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string stripeKey, string dapperContextConnectionString)
        {
            AddStripeInfrastructure(services, stripeKey);

            AddDapperRepositories(services, dapperContextConnectionString);

            return services;
        }

        private static void AddDapperRepositories(IServiceCollection services, string dapperContextConnectionString)
        {
            services.AddSingleton<IDapperContext>(new DapperContext(dapperContextConnectionString));

            services.AddScoped<ISubscriberRepository, DapperSubscriberRepository>();
        }

        private static IServiceCollection AddStripeInfrastructure(IServiceCollection services, string stripeKey)
        {
            StripeConfiguration.ApiKey = stripeKey;

            return services
                .AddScoped<IStripeApiCustomerService, StripeApiCustomerService>()
                .AddScoped<IStripeApiSubscriptionService, StripeApiSubscriptionService>()
                .AddScoped<IStripeApiInvoiceService, StripeApiInvoiceService>()
                .AddScoped<IStripeApiPaymentSessionService, StripeApiPaymentSessionService>()
                .AddScoped<CustomerService>()
                .AddScoped<TokenService>()
                .AddScoped<SubscriptionService>()
                .AddScoped<SubscriptionItemService>()
                .AddScoped<PriceService>()
                .AddScoped<InvoiceService>()
                .AddScoped<SessionService>()
                .AddScoped<InvoiceItemService>();
        }
    }
}
