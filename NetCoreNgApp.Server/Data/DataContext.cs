using Microsoft.EntityFrameworkCore;
using NetCoreNgApp.Server.Entities;

namespace NetCoreNgApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}
