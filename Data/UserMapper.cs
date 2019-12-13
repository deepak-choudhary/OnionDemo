using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace OnionService.Data
{
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityBuilder)

        {

            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.Email).IsRequired();

            entityBuilder.Property(t => t.Password).IsRequired();

            entityBuilder.Property(t => t.Email).IsRequired();

            entityBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);

        }
    }
}