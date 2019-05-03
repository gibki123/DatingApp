using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
namespace DatingApp.API.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}