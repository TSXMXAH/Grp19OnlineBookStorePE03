using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );
        }
    }
}
