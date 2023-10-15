namespace Core.Entities;
public class ProductVariant : BaseAuditableEntity
{
    public string? SKU { get; set; }
    public decimal Prince { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public IList<ProductVariantOption> ProductVariantOptions { get; private set; } = new List<ProductVariantOption>();
    public IList<PurchaseDetail> PurchaseDetails { get; private set; } = new List<PurchaseDetail>();
    public IList<OrderDetail> OrderDetails { get; private set; } = new List<OrderDetail>();
}
