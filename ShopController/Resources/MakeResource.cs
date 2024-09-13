using System.Collections.ObjectModel;

namespace ShopController.Resources;

public class MakeResource : BaseModelResource
{
    public ICollection<KeyValuePairResource> Models { get; set; }
    public MakeResource()
    {
        Models = new Collection<KeyValuePairResource>();
    }
}
