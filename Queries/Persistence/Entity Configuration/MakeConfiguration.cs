using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Queries.Core.Domain;

namespace Queries.Persistence.Entity_Configuration;

public class MakeConfiguration : IEntityTypeConfiguration<Make>
{
    public void Configure(EntityTypeBuilder<Make> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasColumnType("text");
        builder.HasMany(m => m.Models)
            .WithOne(m => m.Make)
            .HasForeignKey(m => m.MakeId)
            .IsRequired(true);
    }
}
