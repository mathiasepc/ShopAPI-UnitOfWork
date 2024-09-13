
namespace Queries.Core.Domain;

public class Item : BaseModel
{
    public int ItemNumber { get; set; }
    public int Price { get; set; }
    public DateTime Released { get; set; }
    public string Color { get; set; }
    public string Material { get; set; }
}
