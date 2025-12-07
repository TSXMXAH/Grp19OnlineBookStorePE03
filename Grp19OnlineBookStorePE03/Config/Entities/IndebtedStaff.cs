using Grp19OnlineBookStorePE03.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class IndebtedStaff: IEntityTypeConfiguration<Staff>
        {
            public void Configure(EntityTypeBuilder<Staff> builder)
            {
                builder.HasData(
                    new Staff
                    {
                        Id = 1,
                        Name = "BookStaff",
                        Password = "123",
                        
                    },
                    new Staff
                    {
                        Id = 2,
                        Name = "MiscStaff",
                        Password = "321",
                     
                    }
                    );
            }
        }
}
