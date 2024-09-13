using Queries.Core.IRepositories;

namespace Queries.Core;

public interface IUnitOfWork : IDisposable
{
    public IItemRepo ItemRepo { get; }

    Task<int> CompleteAsync();
}
