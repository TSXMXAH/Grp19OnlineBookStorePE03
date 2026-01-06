using Grp19OnlineBookStorePE03.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Sarah",
                    Address = "676 Tampines Drive, Stree 41",
                    ContactNum = "86605947",
                    Login = "sarah123",
                    Password = "password123"
                }
                );
        }
    }
}
