using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IDataCenterDbContext
    {
        DbSet<FirstFreightAPI.Entities.DataCenter.Contact> Contacts { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
