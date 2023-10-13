namespace Core.Entities;
public class PurchaseDetail
{
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; } = null!;
    public int ProductVariantId { get; set; }
    public ProductVariant ProductVariant { get; set; } = null!;
    public decimal PurchasePrice { get; set; }
    public int Quantity { get; set; }
}
