using Queries.Core;
using Queries.Core.IRepositories;
using Queries.Persistence.Repositories;

namespace Queries.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _dbContext;
    public UnitOfWork(DatabaseContext dbContext)
    {
        _dbContext = dbContext;

        ItemRepo = new ItemRepo(dbContext);
        MakeRepo = new MakeRepo(dbContext);
    }

    public IItemRepo ItemRepo { get; private set; }
    public IMakeRepo MakeRepo { get; private set; }

    public async Task<int> CompleteAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
