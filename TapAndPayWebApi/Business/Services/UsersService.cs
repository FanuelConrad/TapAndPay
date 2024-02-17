using TapAndPayWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Business.Services
{
    public class UsersService : IUsersService
    {
        private readonly IRepository<User> _usersRepository;

        public UsersService(IRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _usersRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _usersRepository.GetByIdAsync(id);
        }

        public async Task AddUserAsync(User user)
        {
            await _usersRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _usersRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            await _usersRepository.DeleteAsync(id);
        }
    }
}