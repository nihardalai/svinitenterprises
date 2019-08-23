using System.Collections.Generic;
using System.Threading.Tasks;
using SvinitEnterprises.API.Models;

namespace SvinitEnterprises.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}