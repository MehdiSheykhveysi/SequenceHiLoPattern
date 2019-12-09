using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SequenceHiloPattern.Entitties;

namespace SequenceHiloPattern.DataBase.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Price).HasColumnType("decimal(10,2)");
            builder.Property(c => c.ID).ValueGeneratedOnAdd();  //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
            builder.Property(p => p.ManufactureDate).IsRequired();
            builder.HasOne(c => c.Category).WithMany(P => P.Products).HasForeignKey(FK => FK.CategoryId);
            builder.Property(c => c.ID).HasDefaultValueSql("newsequentialid()"); //Use Sequential Guid In SqlServer For Generate Key
        }
    }
}
