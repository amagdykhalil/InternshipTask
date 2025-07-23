using InternshipTask.BusinessLayer.DTOs;

namespace InternshipTask.BusinessLayer.Services.Abstractions
{
    public interface IUserService
    {
        Task AddUserAsync(AddUserDTO userDTO, CancellationToken cancellationToken = default);
    }
}
