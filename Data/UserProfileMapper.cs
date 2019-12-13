using Microsoft.EntityFrameworkCore.Metadata.Builders;

 

namespace OnionService.Data

{

    public class  UserProfileMapper

    {

        public UserProfileMapper(EntityTypeBuilder<UserProfile> entityBuilder)

        {

            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.FirstName).IsRequired();

            entityBuilder.Property(t => t.LastName).IsRequired();

            entityBuilder.Property(t => t.Address);  

        }

    }

}