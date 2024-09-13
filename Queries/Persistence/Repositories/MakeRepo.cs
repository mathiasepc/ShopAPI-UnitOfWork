
using Microsoft.EntityFrameworkCore;
using Queries.Core.Domain;
using Queries.Core.IRepositories;

namespace Queries.Persistence.Repositories;

public class MakeRepo : IMakeRepo
{
    private readonly DatabaseContext _context;

    public MakeRepo(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Make>> GetMake()
    {
        return await _context.Makes.Include(m => m.Models).ToListAsync();
    }
}
