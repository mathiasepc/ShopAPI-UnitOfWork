namespace ShopController.Resources;

public class BaseModelResource
{
    private Guid _id;
    public string Name { get; set; }
    public Guid Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public BaseModelResource() 
    { 
        _id = Guid.NewGuid();
    }
}
