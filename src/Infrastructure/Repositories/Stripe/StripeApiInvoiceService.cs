using Infrastructure.ExternalApi.Stripe;
using Microsoft.Extensions.Logging;
using Stripe;
using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using OneOf;
using Application.Repositories.Stripe.Entities.Invoice.Update;
using Application.Repositories.Stripe.Entities.Invoice.Pay;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using Application.Repositories.Stripe.Entities.Invoice.Get;

namespace Infrastructure.Repositories.Stripe
{
    internal class StripeApiInvoiceService : BaseStripeProcessor, IStripeApiInvoiceService
    {
        private const string StripeInvoiceMetaDataForFirstFreightInvoiceId = "FirstFreightInvoiceId";
        const string StripeCurrencyCode = "usd";
        const string StripeInvoiceMethod = "send_invoice";

        private readonly InvoiceService _invoiceService;
        private readonly InvoiceItemService _invoiceItemService;

        public object Status { get; private set; }

        public StripeApiInvoiceService(
            ILogger<BaseStripeProcessor> logger,
            InvoiceService invoiceService,
            InvoiceItemService invoiceItemService)
                : base(logger)
        {
            _invoiceService = invoiceService;
            _invoiceItemService = invoiceItemService;
        }

        public async Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>> ListStripeInvoiceAsync(ListStripeInvoiceRequest listStripeInvoiceRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand((Func<Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>>>)(async () =>
            {
                StripeList<Invoice> invoices = await _invoiceService.ListAsync(new InvoiceListOptions
                {
                    Customer = listStripeInvoiceRequest.StripeCustomerId
                });

                IEnumerable<StripeInvoiceDto> invoiceDtos = invoices.Select(x => new StripeInvoiceDto
                {
                    StripeInvoiceId = x.Id,
                    FirstFreightInvoiceId = TryGetStripeInvoiceMetaDataForFirstFreightInvoiceId(x),
                    IsPaid = x.Paid,
                    IsPaidOutOfBand = x.PaidOutOfBand,
                    Status = x.Status,
                    HostedInvoiceUrl = x.HostedInvoiceUrl
                });

                return new ListStripeInvoiceResponse(invoiceDtos.ToArray());
            }));
        }

        private static string? TryGetStripeInvoiceMetaDataForFirstFreightInvoiceId(Invoice x)
        {
            x.Metadata.TryGetValue(StripeInvoiceMetaDataForFirstFreightInvoiceId, out string? value);
            return value;
        }

        public async Task<OneOf<AddStripeInvoiceResponse, ReposityFailedResponse>> AddStripeInvoiceAsync(AddStripeInvoiceRequest addStripeInvoiceRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand((Func<Task<OneOf<AddStripeInvoiceResponse, ReposityFailedResponse>>>)(async () =>
            {
                Invoice invoice = await _invoiceService.CreateAsync(new InvoiceCreateOptions
                {
                    Customer = addStripeInvoiceRequest.StripeCustomerId,
                    Currency = StripeCurrencyCode,
                    CollectionMethod = StripeInvoiceMethod,
                    DueDate = addStripeInvoiceRequest.DueDateInUtc,
                    Metadata = GetMetadata(addStripeInvoiceRequest.FirstFreightInvoiceId)
                });

                _ = await _invoiceItemService.CreateAsync(new InvoiceItemCreateOptions
                {
                    Customer = addStripeInvoiceRequest.StripeCustomerId,
                    Amount = addStripeInvoiceRequest.CostInCents,
                    Invoice = invoice.Id,
                    Currency = StripeCurrencyCode
                });

                Invoice finalizedInvoice = await _invoiceService.FinalizeInvoiceAsync(invoice.Id);

                return new AddStripeInvoiceResponse(finalizedInvoice.Id, finalizedInvoice.HostedInvoiceUrl);
            }));
        }

        public async Task<OneOf<UpdateStripeInvoiceResponse, ReposityFailedResponse>> UpdateStripeInvoiceAsync(UpdateStripeInvoiceRequest updateStripeInvoiceRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand<UpdateStripeInvoiceResponse>(async () =>
            {
                Invoice invoice;

                if (!updateStripeInvoiceRequest.IsDraft)
                {
                    const string StripeRevisionAction = "revision";

                    invoice = await _invoiceService.CreateAsync(new InvoiceCreateOptions
                    {
                        FromInvoice = new InvoiceFromInvoiceOptions
                        {
                            Invoice = updateStripeInvoiceRequest.StripeInvoiceId,
                            Action = StripeRevisionAction
                        }
                    });
                }
                else
                {
                    invoice = await _invoiceService.GetAsync(updateStripeInvoiceRequest.StripeInvoiceId);
                }

                InvoiceLineItem? revisedInvoiceLineItem = invoice.Lines.FirstOrDefault();

                if (revisedInvoiceLineItem == null)
                {
                    throw new Exception();
                }

                await _invoiceService.UpdateAsync(invoice.Id, new InvoiceUpdateOptions
                {
                    DueDate = updateStripeInvoiceRequest.DueDateInUtc
                });

                await _invoiceItemService.UpdateAsync(revisedInvoiceLineItem.Id, new InvoiceItemUpdateOptions
                {
                    Amount = updateStripeInvoiceRequest.CostInCents
                });

                Invoice finalizedRevisedInvoice = await _invoiceService.FinalizeInvoiceAsync(invoice.Id);

                return new UpdateStripeInvoiceResponse(finalizedRevisedInvoice.Id, finalizedRevisedInvoice.HostedInvoiceUrl);
            });
        }

        public async Task<OneOf<PayStripeInvoiceResponse, ReposityFailedResponse>> PayStripeInvoiceAsync(PayStripeInvoiceRequest invoice, CancellationToken ct)
        {
            return await TryProcessStripeCommand<PayStripeInvoiceResponse>(async () =>
            {
                InvoicePayOptions invoicePayOptions = new()
                {
                    PaidOutOfBand = true,
                };

                Invoice paidInvoice = await _invoiceService.PayAsync(invoice.InvoiceId, invoicePayOptions, null, ct);

                return new PayStripeInvoiceResponse();
            });
        }

        private static Dictionary<string, string> GetMetadata(string firstFreightInvoiceId)
        {
            return new Dictionary<string, string>
            {
                { StripeInvoiceMetaDataForFirstFreightInvoiceId, firstFreightInvoiceId }
            };
        }
    }
}
