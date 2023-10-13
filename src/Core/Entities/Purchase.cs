namespace Core.Entities;
public class Purchase : BaseAuditableEntity
{
    public DateTime PurchaseDate { get; set; }
    public string? Description { get; set; }
    public IList<PurchaseDetail> PurchaseDetails { get; private set; } = new List<PurchaseDetail>();
}
