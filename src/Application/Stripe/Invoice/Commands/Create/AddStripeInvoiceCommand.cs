using Application.Common;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Stripe.Invoice.Commands.Create
{
    public class AddStripeInvoiceCommand
        : IRequest<ApplicationResponse<AddStripeInvoiceResponse>>
    {
        [Required]
        public string FirstFreightInvoiceId { get; set; }

        [Required]
        public int SubscriberId { get; set; }

        [Required]
        public long CostInCents { get; set; }

        [Required]
        public DateTime DueDateInUtc { get; set; }
    }
}
