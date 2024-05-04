using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Application.Repositories.Stripe.Entities.Invoice.Pay;
using Application.Repositories.Stripe.Entities.Invoice.Update;
using OneOf;

namespace Application.Repositories.Stripe
{
    public interface IStripeApiInvoiceService
    {
        Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>> ListStripeInvoiceAsync(ListStripeInvoiceRequest listStripeInvoiceRequest, CancellationToken ct);
        Task<OneOf<AddStripeInvoiceResponse, ReposityFailedResponse>> AddStripeInvoiceAsync(AddStripeInvoiceRequest invoice, CancellationToken ct);
        Task<OneOf<UpdateStripeInvoiceResponse, ReposityFailedResponse>> UpdateStripeInvoiceAsync(UpdateStripeInvoiceRequest invoice, CancellationToken ct);
        Task<OneOf<PayStripeInvoiceResponse, ReposityFailedResponse>> PayStripeInvoiceAsync(PayStripeInvoiceRequest invoice, CancellationToken ct);
    }
}
