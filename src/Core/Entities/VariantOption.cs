namespace Core.Entities;
public class VariantOption : BaseEntity
{
    public string? Value { get; set; }
    public int VariantId { get; set; }
    public Variant Variant { get; set; } = null!;
}
