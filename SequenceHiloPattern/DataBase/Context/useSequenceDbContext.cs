using Microsoft.EntityFrameworkCore;
using SequenceHiloPattern.Entitties;
using System;

namespace SequenceHiloPattern.DataBase.Context
{
    public class UseSequenceDbContext : DbContext
    {

        public UseSequenceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.HasSequence<int>("DBSequence"); If You Wanna Use Sequence Comment Out This Line
            // modelBuilder.ForSqlServerUseSequenceHiLo("DBSequenceHiLo");Comment out This Line For Use Sequence Hilo 
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
