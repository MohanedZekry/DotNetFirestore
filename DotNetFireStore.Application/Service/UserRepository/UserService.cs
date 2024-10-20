using DotNetFireStore.Application.IService.ICommon;
using DotNetFireStore.Application.IService.IUserService;
using DotNetFireStore.Domain.Entities;

namespace DotNetFireStore.Application.Service.UserRepository
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _userRepository;
        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddUserAsync(User user)
        {
            user.ID = Guid.NewGuid().ToString();
            await _userRepository.AddAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            var student = await _userRepository.GetByIdAsync(id);
            if (student != null)
            {
                await _userRepository.DeleteAsync(student);
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
    }
}
