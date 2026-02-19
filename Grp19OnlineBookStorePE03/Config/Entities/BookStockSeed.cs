using Grp19OnlineBookStorePE03.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class BookStockSeed : IEntityTypeConfiguration<BookStock>
    {
        public void Configure(EntityTypeBuilder<BookStock> builder)
        {
            builder.HasData(
                new BookStock
                {
                    Id = 1,
                    BookId = 1,
                    Quantity = 5,
                   
                },
                new BookStock
                {
                    Id = 2,
                    BookId = 2,
                    Quantity = 3,
                
                },
                new BookStock
                {
                    Id = 3,
                    BookId = 3,
                    Quantity = 7,  
                }
            );
        }
    }
}