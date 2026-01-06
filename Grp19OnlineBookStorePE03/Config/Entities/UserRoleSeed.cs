using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "c1a2b3c4-d5e6-4789-8901-234567890abc",
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba" // Admin Role
                }
            );
        }
    }
}
