using Grp19OnlineBookStorePE03.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Category = "Romance",
                    Price = 17.20M,
                    Author = "Holly Black",
                    Title = "The Cruel Prince",
                    StaffId = 1
                },
                new Book
                {
                    Id = 2,
                    Category = "Comedy",
                    Price = 18.50M,
                    Author = "Vince Elson",
                    Title = "The Laughing King",
                    StaffId = 1
                },
                new Book
                {
                    Id = 3,
                    Category = "Romance",
                    Price = 16.50M,
                    Author = "Holly Black",
                    Title = "The Queen Of Nothing",
                    StaffId = 1
                }
                );
        }
    }
}
