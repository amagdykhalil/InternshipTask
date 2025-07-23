using InternshipTask.DataLayer.Entities;

namespace InternshipTask.DataLayer.Repositories.Abstractions
{
    public interface IUserRepository
    {
        Task AddAsync(User entity, CancellationToken cancellationToken = default);
        /// <summary>
        /// Saves all changes made in this context to the database asynchronously.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>The task result contains the number of state entries written to the database.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
