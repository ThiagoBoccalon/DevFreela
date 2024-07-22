using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUsersAsync(int id);
        Task AddAsync(User user);
        Task SaveChangesAsync();
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
    }
}
