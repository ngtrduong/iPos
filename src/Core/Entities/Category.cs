namespace Core.Entities;
public class Category : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Code { get; set; }
    public bool IsDisabled { get; set; }
    public IList<ProductCategory> ProductCategory { get; private set; } = new List<ProductCategory>();
}
