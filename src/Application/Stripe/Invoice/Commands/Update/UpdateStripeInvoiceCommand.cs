using Application.Common;
using Application.Repositories.Stripe.Entities.Invoice.Update;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Stripe.Invoice.Commands.Update
{
    public class UpdateStripeInvoiceCommand
        : IRequest<ApplicationResponse<UpdateStripeInvoiceResponse>>
    {
        [Required]
        public string FirstFreightInvoiceId { get; set; }

        [Required]
        public int SubscriberId { get; set; }

        [Required]
        public long CostInCents { get; set; }

        [Required]
        public DateTime? DueDateInUtc { get; set; }
    }
}
