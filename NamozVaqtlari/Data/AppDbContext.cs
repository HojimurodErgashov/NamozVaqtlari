using Microsoft.EntityFrameworkCore;
using NamozVaqtlari.Model.Users;

namespace NamozVaqtlari.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}

        public DbSet<User> Users { get; set; }
    }
}
