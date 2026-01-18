using Grp19OnlineBookStorePE03.Classes;
using Grp19OnlineBookStorePE03.Config.Entities;
using Grp19OnlineBookStorePE03.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Grp19OnlineBookStorePE03.Data
{
    public class Grp19OnlineBookStorePE03Context(DbContextOptions<Grp19OnlineBookStorePE03Context> options) : IdentityDbContext<OnlineBookStoreUser>(options)
    {
        public DbSet<Grp19OnlineBookStorePE03.Classes.Staff> Staff { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Customer> Customer { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Book> Book { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Misc> Misc { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Order> Order { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Payment> Payment { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.CartItem> CartItem{ get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.WishlistItem> WishlistItem { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<WishlistItem>()
                .HasOne(w => w.Book)
                .WithMany()
                .HasForeignKey(w => w.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WishlistItem>()
                .HasOne(w => w.Misc)
                .WithMany()
                .HasForeignKey(w => w.MiscId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new BookSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new MiscSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
