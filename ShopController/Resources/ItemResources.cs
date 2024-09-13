using System.ComponentModel.DataAnnotations;

namespace ShopController.Resources;

public class ItemResources : BaseModelResources
{
    public int ItemNumber { get; set; }
    public int Price { get; set; }
    public DateTime Released { get; set; }
    public string Color { get; set; }
    public string Material { get; set; }
}
