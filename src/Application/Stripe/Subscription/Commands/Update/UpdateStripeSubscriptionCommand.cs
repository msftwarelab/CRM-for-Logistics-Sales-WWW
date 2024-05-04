using Application.Common;
using Application.Repositories.Stripe.Entities.Subscription.Update;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Stripe.Subscription.Commands.Update
{
    public class UpdateStripeSubscriptionCommand
        : IRequest<ApplicationResponse<UpdateStripeSubscriptionResponse>>
    {
        [Required]
        public int SubscriberId { get; set; }
    }
}
