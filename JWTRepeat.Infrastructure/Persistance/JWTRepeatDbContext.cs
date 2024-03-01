using JWTRepeat.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTRepeat.Infrastructure.Persistance
{
    public class JWTRepeatDbContext : DbContext
    {
        public JWTRepeatDbContext(DbContextOptions<JWTRepeatDbContext> options)
            : base(options) => Database.Migrate();

        public virtual DbSet<User> Users { get; set; }
    }
}
