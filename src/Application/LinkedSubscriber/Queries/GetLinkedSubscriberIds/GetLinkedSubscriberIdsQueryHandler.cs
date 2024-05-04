using Application.Common;
using Application.Repositories.LinkedSubscriber;
using Domain.Enums;
using MediatR;

namespace Application.LinkedSubscriber.Queries.GetLinkedSubscriberIds
{
    public class GetLinkedSubscriberIdsQueryHandler :
        BaseHandler,
        IRequestHandler<GetLinkedSubscriberIdsQuery, ApplicationResponse<LinkedSubscriberIdsViewModel>>
    {
        private readonly ISubscriberRepository _subscriberRepository;

        public GetLinkedSubscriberIdsQueryHandler(ISubscriberRepository subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
        }

        public async Task<ApplicationResponse<LinkedSubscriberIdsViewModel>> Handle(GetLinkedSubscriberIdsQuery request, CancellationToken cancellationToken)
        {
            LinkedSubscriberIdsViewModel result = new();
            List<int> linkedIds = await _subscriberRepository.GetLinkedSubscriberIds(request.SubscriberId);
            result.LinkedSubscriberIds.AddRange(linkedIds);
            return GetResult(result, ResultType.Ok);
        }
    }
}