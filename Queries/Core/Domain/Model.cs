using System.Collections.ObjectModel;

namespace Queries.Core.Domain;

public class Model : BaseModel
{
    public Guid MakeId { get; set; }
    public Make Make { get; set; }
    public ICollection<Item> Items { get; set; }

    public Model() 
    {
        Items = new Collection<Item>();
    }
}
