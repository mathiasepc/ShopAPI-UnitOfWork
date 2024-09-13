
using Queries.Core.Domain;

namespace Queries.Core.IRepositories;

public interface IItemRepo
{
    Task InsertItem(Item item);
}
