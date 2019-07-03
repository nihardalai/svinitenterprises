using Microsoft.EntityFrameworkCore;
using SvinitEnterprises.API.Models;

namespace SvinitEnterprises.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Value> Values { get; set; }
    }
}