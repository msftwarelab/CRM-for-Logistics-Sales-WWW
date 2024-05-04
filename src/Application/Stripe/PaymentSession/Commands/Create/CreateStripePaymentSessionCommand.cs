using Application.Common;
using Application.Repositories.Stripe.Entities.PaymentSession.Create;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Stripe.PaymentSession.Commands.Create
{
    public class CreateStripePaymentSessionCommand
        : IRequest<ApplicationResponse<CreatePaymentSessionResponse>>
    {
        [Required]
        public int SubscriberId { get; set; }
        
        [Required]
        public string SuccessUrl { get; set; }
        
        [Required]
        public string CancelUrl { get; set; }
        
        [Required]
        public PaymentSessionFrequency PaymentSessionFrequency { get; set; }
    }
}
