using Microsoft.EntityFrameworkCore;

namespace SequenceHiloPattern.DataBase.Context
{
    public class SequenceHiloContext:DbContext
    {
        public SequenceHiloContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
            Database.EnsureDeleted();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence("DBSequence");
            base.OnModelCreating(modelBuilder);
        }
    }
}
