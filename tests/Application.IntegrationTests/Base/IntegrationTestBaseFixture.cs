using Infrastructure.Persistence.DbContexts.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Respawn;

namespace Application.IntegrationTests.Base
{
    public class IntegrationTestBaseFixture : IDisposable
    {
        private static WebApplicationFactory<Program> _defaultFactory = null!;
        private static WebApplicationFactory<Program> _tempFactory = null!;
        private static IConfiguration _configuration = null!;
        private static IServiceScopeFactory _scopeFactory = null!;
        private static Respawner _checkpoint = null!;
        private static string? _currentUserId;

        public IntegrationTestBaseFixture()
        {
            _defaultFactory = _tempFactory = new CustomWebApplicationFactory();
            _scopeFactory = _tempFactory.Services.GetRequiredService<IServiceScopeFactory>();
            _configuration = _tempFactory.Services.GetRequiredService<IConfiguration>();

            // Initialise Db
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<SharedDbContext>();
            context.Database.EnsureDeleted();
            context.Database.Migrate();

            _checkpoint = Respawner.CreateAsync(_configuration.GetConnectionString("DefaultConnection")!, new RespawnerOptions
            {
                TablesToIgnore = new Respawn.Graph.Table[] { "__EFMigrationsHistory" }
            }).GetAwaiter().GetResult();
        }

        public static async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            using var scope = _scopeFactory.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<ISender>();

            return await mediator.Send(request);
        }

        public static async Task SendAsync(IBaseRequest request)
        {
            using var scope = _scopeFactory.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<ISender>();

            await mediator.Send(request);
        }

        public static void OverrideScopeService<TInterface>(TInterface mock)
            where TInterface : class
        {
            _tempFactory = _tempFactory.WithWebHostBuilder(services =>
            {
                services.ConfigureServices(services =>
                {
                    services.Remove<TInterface>();
                    services.AddSingleton(mock);
                });
            });

            _scopeFactory = _tempFactory.Services.GetRequiredService<IServiceScopeFactory>();
        }

        public static async Task ResetState()
        {
            try
            {
                _tempFactory = _defaultFactory;
                _scopeFactory = _tempFactory.Services.GetRequiredService<IServiceScopeFactory>();

                await _checkpoint.ResetAsync(_configuration.GetConnectionString("DefaultConnection")!);
            }
            catch (Exception)
            {
            }

            _currentUserId = null;
        }

        public static async Task<TEntity?> FindAsync<TEntity>(params object[] keyValues)
            where TEntity : class
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<SharedDbContext>();

            return await context.FindAsync<TEntity>(keyValues);
        }

        public static async Task AddAsync<TEntity>(TEntity entity)
            where TEntity : class
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<SharedDbContext>();

            context.Add(entity);

            await context.SaveChangesAsync();
        }

        public static async Task<int> CountAsync<TEntity>() where TEntity : class
        {
            using var scope = _scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<SharedDbContext>();

            return await context.Set<TEntity>().CountAsync();
        }

        public void Dispose()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<SharedDbContext>();
            context.Database.EnsureDeleted();
        }
    }

}
