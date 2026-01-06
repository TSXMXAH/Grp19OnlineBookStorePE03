using Grp19OnlineBookStorePE03.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class UserSeed : IEntityTypeConfiguration<OnlineBookStoreUser>
    {
        public void Configure(EntityTypeBuilder<OnlineBookStoreUser> builder)
        {
            var hasher = new PasswordHasher<OnlineBookStoreUser>();
            builder.HasData(
                new OnlineBookStoreUser
                {
                    Id = "c1a2b3c4-d5e6-4789-8901-234567890abc",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
                );
        }
    }
}
