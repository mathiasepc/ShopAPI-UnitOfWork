using Microsoft.EntityFrameworkCore;
using Queries.Core.Domain;
using Queries.Persistence.Entity_Configuration;

namespace Queries.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option) { }
    public virtual DbSet<Item> Items { get; set; }
    public virtual DbSet<Make> Makes { get; set; }
    public virtual DbSet<Model> Models { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItemConfigure());
        modelBuilder.ApplyConfiguration(new MakeConfiguration());
        modelBuilder.ApplyConfiguration(new ModelConfiguration());

        // Definerer data for Makes
        modelBuilder.Entity<Make>().HasData(
            new Make { Id = Guid.Parse("b7f26ac9-5b71-497f-b0a5-5c683e267181"), Name = "Phillips" },
            new Make { Id = Guid.Parse("b9c77744-3064-4d72-b349-ba12a23fecf7"), Name = "Lego" },
            new Make { Id = Guid.Parse("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"), Name = "Spil" }
        );

        // Definerer data for Models
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = Guid.Parse("42532caa-0a7f-4556-bcb2-43113ddb7386"), Name = "55OLED708", MakeId = Guid.Parse("b7f26ac9-5b71-497f-b0a5-5c683e267181") },
            new Model { Id = Guid.Parse("acb956e0-7a1f-48c1-b100-7e9f35d9411b"), Name = "50PUS8079", MakeId = Guid.Parse("b7f26ac9-5b71-497f-b0a5-5c683e267181") },
            new Model { Id = Guid.Parse("e0799875-c7cd-4c34-b119-9ce3d9f5f742"), Name = "48OLED708", MakeId = Guid.Parse("b7f26ac9-5b71-497f-b0a5-5c683e267181") },
            new Model { Id = Guid.Parse("5f708c2e-5497-4b8f-a8e2-d393d7ef1540"), Name = "Millennium Falcon", MakeId = Guid.Parse("b9c77744-3064-4d72-b349-ba12a23fecf7") },
            new Model { Id = Guid.Parse("c956850a-e488-420f-8611-dd30849aaa8e"), Name = "R2-D2", MakeId = Guid.Parse("b9c77744-3064-4d72-b349-ba12a23fecf7") },
            new Model { Id = Guid.Parse("91414760-4cef-4da4-8c91-00e2b18078b2"), Name = "AT-AT", MakeId = Guid.Parse("b9c77744-3064-4d72-b349-ba12a23fecf7") },
            new Model { Id = Guid.Parse("e5c7929a-956d-4e29-9b86-22f472430933"), Name = "Read dead redemption", MakeId = Guid.Parse("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a") },
            new Model { Id = Guid.Parse("c06435a9-1913-4a52-a415-01c93753c388"), Name = "Call of duty", MakeId = Guid.Parse("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a") },
            new Model { Id = Guid.Parse("c2dc45ee-9bb0-42e9-b625-aeddc53da952"), Name = "Counter strike 2", MakeId = Guid.Parse("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a") }
        );

    }
}
