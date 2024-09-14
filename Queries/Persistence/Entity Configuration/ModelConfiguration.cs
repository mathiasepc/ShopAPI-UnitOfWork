
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Queries.Core.Domain;

namespace Queries.Persistence.Entity_Configuration;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder) 
    { 
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasColumnType("text");
        builder.HasMany(i => i.Items)
            .WithOne(m => m.Model)
            .HasForeignKey(m => m.ModelId)
            .IsRequired(true);

    }
}
