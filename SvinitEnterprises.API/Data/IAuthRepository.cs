using SvinitEnterprises.API.Models;
using System.Threading.Tasks;

namespace SvinitEnterprises.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}