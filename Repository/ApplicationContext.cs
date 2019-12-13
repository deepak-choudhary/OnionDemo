using Microsoft.EntityFrameworkCore;
using OnionService.Data;
 
namespace OnionService.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMapper(modelBuilder.Entity<User>());
            new UserProfileMapper(modelBuilder.Entity<UserProfile>());
        }
    }
}