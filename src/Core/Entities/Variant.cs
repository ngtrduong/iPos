namespace Core.Entities;
public class Variant : BaseAuditableEntity
{
    public string? Name { get; set; }
    public IList<VariantOption> VariantOptions { get; private set; } = new List<VariantOption>();
}
