using FirstFreightAPI.Entities.Shared;

namespace Application.Repositories.LinkedSubscriber
{
    public interface ISubscriberRepository
    {
        Task<List<int>> GetLinkedSubscriberIds(int subscriberId);
        Task<IEnumerable<GlobalCompany>> GetGlobalCompaniesAsync(List<int> globalUserIds, int userIdGlobal);
    }
}
