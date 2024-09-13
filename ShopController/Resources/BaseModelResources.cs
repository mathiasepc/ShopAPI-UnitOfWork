namespace ShopController.Resources;

public class BaseModelResources
{
    private Guid _id;
    public string Name { get; set; }
    public Guid Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public BaseModelResources() 
    { 
        _id = Guid.NewGuid();
    }
}
