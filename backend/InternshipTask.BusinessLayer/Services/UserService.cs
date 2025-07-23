using InternshipTask.BusinessLayer.DTOs;
using InternshipTask.BusinessLayer.Services.Abstractions;
using InternshipTask.DataLayer.Entities;
using InternshipTask.DataLayer.Repositories.Abstractions;

namespace InternshipTask.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddUserAsync(AddUserDTO userDTO, CancellationToken cancellationToken = default)
        {
            User user = new User
            {
                Email = userDTO.Email,
                UserName = userDTO.UserName
            };
            await _userRepository.AddAsync(user, cancellationToken);
            await _userRepository.SaveChangesAsync(cancellationToken);
        }
    }
}
