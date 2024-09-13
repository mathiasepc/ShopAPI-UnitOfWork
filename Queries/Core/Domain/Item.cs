
namespace Queries.Core.Domain;

public class Item : BaseModel
{
    public int ItemNumber { get; set; }
    public int Price { get; set; }
    public DateTime Released { get; set; }
    public Guid ModelId { get; set; }
    public Model Model { get; set; }
}
