using Microsoft.EntityFrameworkCore;
using NamozVaqtlari.Model.Users;

namespace NamozVaqtlari.Data
{
    public class AppDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("NamozVaqtlariDatabase"));
        }

        public DbSet<User> Users { get; set; }
    }
}
