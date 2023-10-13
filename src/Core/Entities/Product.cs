namespace Core.Entities;
public class Product : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Code { get; set; }
    public IList<ProductCategory> ProductCategories { get; private set; } = new List<ProductCategory>();
    public IList<ProductVariant> ProductVariants { get; private set; } = new List<ProductVariant>();
}
