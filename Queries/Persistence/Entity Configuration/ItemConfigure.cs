
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Queries.Core.Domain;

namespace Queries.Persistence.Entity_Configuration;

public class ItemConfigure : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasColumnType("text");
        builder.Property(x => x.ItemNumber)
            .HasColumnType("text")
            .HasMaxLength(15);
        builder.Property(x => x.Price)
            .HasColumnType("Integer");
        builder.Property(x => x.Released)
            .HasColumnType("Date");
        
    }
}
