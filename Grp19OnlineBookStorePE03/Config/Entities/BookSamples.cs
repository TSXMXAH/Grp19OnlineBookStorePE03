using Grp19OnlineBookStorePE03.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grp19OnlineBookStorePE03.Config.Entities
{
    public class BookSamples : IEntityTypeConfiguration<Book>
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
                    BookName = "The Cruel Prince"
                },
                new Book
                {
                    Id = 2,
                    Category = "Romance",
                    Price = 18.50M,
                    Author = "Holly Black",
                    BookName = "The Wicked King"
                },
                new Book
                {
                    Id = 3,
                    Category = "Romance",
                    Price = 16.50M,
                    Author = "Holly Black",
                    BookName = "The Queen Of Nothing"
                }
                );
        }
    }
}
