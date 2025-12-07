using Grp19OnlineBookStorePE03.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
        public class MiscSamples : IEntityTypeConfiguration<Misc>
        {
            public void Configure(EntityTypeBuilder<Misc> builder)
            {
                builder.HasData(
                    new Misc
                    {
                        Id = 1,
                        Category = "Stationary",
                        Price = 450,
                        MiscName = " PIX Black Ballpoint Pen"
                    },
                    new Misc
                    {
                        Id = 2,
                        Category = "Office Supplies",
                        Price = 33.00M,
                        MiscName = "Canon Original Black Cartridge"

                    },
                    new Misc
                    {
                        Id = 3,
                        Category = "Wellness",
                        Price = 67.50M,
                        MiscName = "Hitachi HMG-900 Precision Massage Gun"

                    }

                    );
            }
        }
    }
