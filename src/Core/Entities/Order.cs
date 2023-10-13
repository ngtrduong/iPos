namespace Core.Entities;
public class Order : BaseAuditableEntity
{
    public DateTime OrderDate { get; set; }
    public string? Code { get; set; }
    public string? EmployeeId { get; set; }
    public IList<OrderDetail> OrderDetail { get; private set; } = new List<OrderDetail>();
}
