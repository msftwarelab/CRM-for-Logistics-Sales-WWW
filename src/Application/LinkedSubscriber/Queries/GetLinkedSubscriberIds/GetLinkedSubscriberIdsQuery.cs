using Application.Common;
using MediatR;

namespace Application.LinkedSubscriber.Queries.GetLinkedSubscriberIds
{
    public class GetLinkedSubscriberIdsQuery
        : IRequest<ApplicationResponse<LinkedSubscriberIdsViewModel>>
    {
        public GetLinkedSubscriberIdsQuery(int subscriberId)
        {
            SubscriberId = subscriberId;
        }
        public int SubscriberId { get; }
    }
}