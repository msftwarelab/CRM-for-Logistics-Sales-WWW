using Application.Common.Interfaces;
using Dapper;
using Application.Repositories.LinkedSubscriber;
using FirstFreightAPI.Entities.Shared;

namespace Infrastructure.Dapper.Repositories.Subscriber
{
    public class DapperSubscriberRepository : ISubscriberRepository
    {
        private readonly IDapperContext _dapperContext;

        public DapperSubscriberRepository(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<List<int>> GetLinkedSubscriberIds(int subscriberId)
        {
            const string Query = @"SELECT DISTINCT t.LinkedSubscriberId 
                FROM LinkGlobalSuscriberToSubscriber AS t 
                INNER JOIN Subscribers AS j ON t.LinkedSubscriberId = j.SubscriberId 
                WHERE t.GlobalSubscriberId = @subscriberId AND j.Deleted = 0;";

            var result = await _dapperContext
                .CreateConnection()
                .QueryAsync<int>(
                    Query,
                    new { subscriberId = subscriberId });

            return result.ToList();
        }

        public async Task<List<int>> GetCompanies(int subscriberId)
        {
            const string Query = @"SELECT * FROM GlobalCompanies t 
                JOIN LinkGlobalCompanyGlobalUser l 
                ON t.GlobalCompanyId = l.GlobalCompanyId 
                WHERE l.Deleted = 0
                AND (l.GlobalUserId IN (100,107) OR l.GlobalUserId = 11767) 
                AND (l.InviteStatus IS NULL OR l.InviteAccepted = 1)";

            var result = await _dapperContext
                .CreateConnection()
                .QueryAsync<int>(
                    Query,
                    new { subscriberId = subscriberId });

            return result.ToList();
        }

        public async Task<IEnumerable<GlobalCompany>> GetGlobalCompaniesAsync(List<int> globalUserIds, int userIdGlobal)
        {
            const string Query = @"SELECT DISTINCT t.* 
                FROM GlobalCompanies t 
                JOIN LinkGlobalCompanyGlobalUser l 
                ON t.GlobalCompanyId = l.GlobalCompanyId 
                WHERE l.Deleted = 0
                AND (l.GlobalUserId IN @GlobalUserIds OR l.GlobalUserId = @UserIdGlobal) 
                AND (l.InviteStatus IS NULL OR l.InviteAccepted = 1)";

            var parameters = new { GlobalUserIds = globalUserIds, UserIdGlobal = userIdGlobal };
            var result = await _dapperContext
                .CreateConnection()
                .QueryAsync<GlobalCompany>(
                    Query, 
                    parameters);

            return result.ToList();
        }
    }
}
