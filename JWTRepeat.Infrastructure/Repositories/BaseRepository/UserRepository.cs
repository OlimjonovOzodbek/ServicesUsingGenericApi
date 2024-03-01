using JWTRepeat.Application.Abstractions;
using JWTRepeat.Domain.Entities;
using JWTRepeat.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace JWTRepeat.Infrastructure.Repositories.BaseRepository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(JWTRepeatDbContext context, DbSet<User> dbSet)
            : base(context, dbSet) { }

    }
}
