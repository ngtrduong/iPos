using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;
public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable(nameof(ProductCategory))
            .HasKey(pk => new { pk.ProductId, pk.CategoryId });

        builder.HasOne(o => o.Product)
            .WithMany(m => m.ProductCategories)
            .HasForeignKey(fk => fk.ProductId);

        builder.HasOne(o => o.Category)
            .WithMany(m => m.ProductCategories)
            .HasForeignKey(fk => fk.CategoryId);
    }
}