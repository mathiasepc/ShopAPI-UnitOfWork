using Microsoft.EntityFrameworkCore;
using Queries.Core.Domain;

namespace Queries.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option) { }
    public virtual DbSet<Item> Items { get; set; }
}
