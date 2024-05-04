using Domain.Entities.Shared;
using FirstFreightAPI.Entities.Shared;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface ISharedDbContext
    {
        DbSet<Document> Documents { get; }
        DbSet<GlobalContact> GlobalContacts { get; }
        DbSet<GlobalCompany> GlobalCompanies { get; }
        DbSet<GlobalUser> GlobalUsers { get; }
        DbSet<FirstFreightAPI.Entities.Shared.Subscriber> Subscribers { get; }
        DbSet<LinkSubscriberToStripeCustomer> LinkSubscriberToStripeCustomers { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
