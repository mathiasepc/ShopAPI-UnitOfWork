using Microsoft.EntityFrameworkCore;
using Queries.Core.Domain;
using Queries.Core.IRepositories;

namespace Queries.Persistence.Repositories;

public class ItemRepo : IItemRepo
{
    private readonly DatabaseContext _context;
    public ItemRepo(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Item>> GetItems()
    {
        return await _context.Items.ToListAsync();
    }

    public async Task InsertItem(Item item)
    {
        await _context.Items.AddAsync(item);
    }
}
