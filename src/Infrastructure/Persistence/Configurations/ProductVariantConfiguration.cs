using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;
public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
{
    public void Configure(EntityTypeBuilder<ProductVariant> builder)
    {
        builder.ToTable(nameof(ProductVariant));

        builder.Property(p => p.SKU)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Prince)
            .HasPrecision(18, 2);

        builder.HasOne(o => o.Product)
            .WithMany(m => m.ProductVariants)
            .HasForeignKey(fk => fk.ProductId);
    }
}