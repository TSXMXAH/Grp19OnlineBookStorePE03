using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grp19OnlineBookStorePE03.Classes;

namespace Grp19OnlineBookStorePE03.Data
{
    public class Grp19OnlineBookStorePE03Context : DbContext
    {
        public Grp19OnlineBookStorePE03Context(DbContextOptions<Grp19OnlineBookStorePE03Context> options)
            : base(options)
        {
        }
        public DbSet<Grp19OnlineBookStorePE03.Classes.Staff> Staff { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Customer> Customer { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Book> Book { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Misc> Misc { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Order> Order { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<Grp19OnlineBookStorePE03.Classes.Payment> Payment { get; set; } = default!;
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // OrderItem → Book
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Book)
                .WithMany()
                .HasForeignKey(oi => oi.BookId)
                .OnDelete(DeleteBehavior.Restrict);   // Prevent cascade delete

            // OrderItem → Misc
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Misc)
                .WithMany()
                .HasForeignKey(oi => oi.MiscId)
                .OnDelete(DeleteBehavior.Restrict);   // Prevent cascade delete
        }

    }
}