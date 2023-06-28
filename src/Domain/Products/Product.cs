namespace IWantApp.Domain.Products;

public abstract class Product : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public string Category { get; set; }
    public bool HasStock { get; set; }

}
