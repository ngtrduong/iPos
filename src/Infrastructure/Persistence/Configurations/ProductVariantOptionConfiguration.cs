using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;
public class ProductVariantOptionConfiguration : IEntityTypeConfiguration<ProductVariantOption>
{
    public void Configure(EntityTypeBuilder<ProductVariantOption> builder)
    {
        builder.ToTable(nameof(ProductVariantOption))
            .HasKey(pk => new { pk.ProductVariantId, pk.VarianOptionId });

        builder.HasOne(o => o.ProductVariant)
            .WithMany(m => m.ProductVariantOptions)
            .HasForeignKey(fk => fk.VarianOptionId);

        builder.HasOne(o => o.VariantOption)
            .WithMany(m => m.ProductVariantOptions)
            .HasForeignKey(fk => fk.VarianOptionId);
    }
}