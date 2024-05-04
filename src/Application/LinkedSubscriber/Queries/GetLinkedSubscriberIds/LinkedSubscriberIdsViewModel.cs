namespace Application.LinkedSubscriber.Queries.GetLinkedSubscriberIds
{
    public class LinkedSubscriberIdsViewModel
    {
        public LinkedSubscriberIdsViewModel()
        {
            LinkedSubscriberIds = new();
        }

        public List<int> LinkedSubscriberIds { get; }
    }
}
