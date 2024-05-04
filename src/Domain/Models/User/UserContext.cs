using Microsoft.EntityFrameworkCore;

namespace FirstFreightAPI.Models.User
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            :base(options) { }
        public DbSet<User> Users { get; set; } = null!;
    }
}
