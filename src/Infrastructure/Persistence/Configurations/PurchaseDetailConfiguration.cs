using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;
public class PurchaseDetailConfiguration : IEntityTypeConfiguration<PurchaseDetail>
{
    public void Configure(EntityTypeBuilder<PurchaseDetail> builder)
    {
        builder.ToTable(nameof(PurchaseDetail))
            .HasKey(pk => new { pk.PurchaseId, pk.ProductVariantId });

        builder.Property(p => p.PurchasePrice)
            .HasPrecision(18, 2);

        builder.HasOne(o => o.Purchase)
            .WithMany(m => m.PurchaseDetails)
            .HasForeignKey(fk => fk.PurchaseId);

        builder.HasOne(o => o.ProductVariant)
            .WithMany(m => m.PurchaseDetails)
            .HasForeignKey(fk => fk.ProductVariantId);
    }
}
