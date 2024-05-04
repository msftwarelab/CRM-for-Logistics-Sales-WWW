using Application.Common;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Stripe.Invoice.Queries.Get
{
    public class GetStripeInvoiceCommand
        : IRequest<ApplicationResponse<StripeInvoiceDto>>
    {
        [Required]
        public int SubscriberId { get; set; }

        [Required]
        public string FirstFreightInvoiceId { get; set; }
    }
}
