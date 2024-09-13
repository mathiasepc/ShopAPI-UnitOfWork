using System.Collections.ObjectModel;

namespace Queries.Core.Domain;

public class Make : BaseModel
{
    public ICollection<Model> Models { get; set; }
    public Make()
    {
        Models = new Collection<Model>();
    }
}
