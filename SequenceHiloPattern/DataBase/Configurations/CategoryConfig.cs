using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SequenceHiloPattern.Entitties;
using System;

namespace SequenceHiloPattern.DataBase.Configurations
{
    class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.HasOne(p => p.Product).WithMany(c => c.Categories).HasForeignKey(FK => FK.ProducId);
        }
    }
}
