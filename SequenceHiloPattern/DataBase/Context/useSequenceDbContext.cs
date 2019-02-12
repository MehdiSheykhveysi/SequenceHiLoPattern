using Microsoft.EntityFrameworkCore;
using SequenceHiloPattern.Entitties;
using System;

namespace SequenceHiloPattern.DataBase.Context
{
    public class UseSequenceDbContext : DbContext
    {
        
        public UseSequenceDbContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
            Database.EnsureDeleted();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasSequence<int>("DBSequence");
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
