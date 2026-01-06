using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grp19OnlineBookStorePE03.Classes;
using Grp19OnlineBookStorePE03.Config.Entities;

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
        

    protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new BookSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new MiscSeed());
        }

    }
}