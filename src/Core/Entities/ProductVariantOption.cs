namespace Core.Entities;
public class ProductVariantOption
{
    public int ProductVariantId { get; set; }
    public ProductVariant ProductVariant { get; set; } = null!;
    public int VarianOptionId { get; set; }
    public VariantOption VariantOption { get; set; } = null!;
}
