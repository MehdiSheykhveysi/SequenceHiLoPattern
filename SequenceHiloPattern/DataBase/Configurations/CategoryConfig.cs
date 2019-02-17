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
            builder.Property(c => c.ID).ValueGeneratedOnAdd();  //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ID).HasDefaultValueSql("newsequentialid()"); //Use Sequential Guid In SqlServer For Generate Key
        }
    }
}
