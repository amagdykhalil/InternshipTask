using InternshipTask.DataLayer.Entities;
using InternshipTask.DataLayer.Repositories.Abstractions;

namespace InternshipTask.DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddAsync(User entity, CancellationToken cancellationToken = default)
        {
            await _appDbContext.Users.AddAsync(entity, cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _appDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
