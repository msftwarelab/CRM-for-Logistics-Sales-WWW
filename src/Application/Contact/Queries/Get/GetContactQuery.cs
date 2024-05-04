using Application.Common;
using MediatR;

namespace Application.Contact.Queries.Get
{
    public class GetContactQuery
        : IRequest<ApplicationResponse<ContactViewModel>>
    {

        public GetContactQuery(int globalContactId, int subscriberId)
        {
            GlobalContactId = globalContactId;
            SubscriberId = subscriberId;
        }

        public int GlobalContactId { get; }
        public int SubscriberId { get; }
    }
}
