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
            builder.Property(p => p.ManufactureDate).IsRequired();
        }
    }
}
