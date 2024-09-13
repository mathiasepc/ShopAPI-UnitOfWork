
namespace ShopController.Resources;

public class ItemResource : BaseModelResource
{
    public int ItemNumber { get; set; }
    public int Price { get; set; }
    public DateTime Released { get; set; }
    public string Color { get; set; }
    public string Material { get; set; }
    public Guid ModelId { get; set; }
    public KeyValuePairResource Model { get; set; }
}
