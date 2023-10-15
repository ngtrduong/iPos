using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;
public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.ToTable(nameof(OrderDetail))
            .HasKey(pk => new { pk.OrderId, pk.ProductVariantId });

        builder.HasOne(o => o.Order)
            .WithMany(m => m.OrderDetail)
            .HasForeignKey(fk => fk.OrderId);

        builder.HasOne(o => o.ProductVariant)
            .WithMany(m => m.OrderDetails)
            .HasForeignKey(fk => fk.ProductVariantId);
    }
}
