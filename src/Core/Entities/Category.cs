namespace Core.Entities;
public class Category : BaseAuditableEntity
{
    public string? Name { get; set; }
    public bool IsDisabled { get; set; }
    public IList<ProductCategory> ProductCategories { get; private set; } = new List<ProductCategory>();
}
