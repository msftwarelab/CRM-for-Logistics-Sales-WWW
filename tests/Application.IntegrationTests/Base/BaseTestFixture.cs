using MediatR;

namespace Application.IntegrationTests.Base
{
    [Collection("Shared Fixture")]
    public abstract class BaseTestFixture
    {
        private readonly IntegrationTestBaseFixture _fixture;

        public BaseTestFixture(IntegrationTestBaseFixture fixture)
        {
            _fixture = fixture;

            IntegrationTestBaseFixture
                .ResetState()
                .GetAwaiter()
                .GetResult();
        }

        public static void OverrideScopeService<TInterface>(TInterface mock)
            where TInterface : class
        {
            IntegrationTestBaseFixture.OverrideScopeService(mock);
        }

        public static async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            return await IntegrationTestBaseFixture.SendAsync(request);
        }

        public static async Task SendAsync(IBaseRequest request)
        {
            await IntegrationTestBaseFixture.SendAsync(request);
        }

        public static async Task<TEntity?> FindAsync<TEntity>(params object[] keyValues)
            where TEntity : class
        {
            return await IntegrationTestBaseFixture.FindAsync<TEntity>(keyValues);
        }

        public static async Task AddAsync<TEntity>(TEntity entity)
            where TEntity : class
        {
            await IntegrationTestBaseFixture.AddAsync(entity);
        }

        public static async Task<int> CountAsync<TEntity>() where TEntity : class
        {
            return await IntegrationTestBaseFixture.CountAsync<TEntity>();
        }
    }
}